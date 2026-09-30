using Microsoft.EntityFrameworkCore;
using TtlNetCoreLAB06_EF.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Kết nối Database
builder.Services.AddDbContext<TtlProductDbContext>(options =>
	options.UseSqlServer(
		builder.Configuration.GetConnectionString("TtlProductDB")
	));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();

// QUAN TRỌNG: cho phép load CSS, JS, Bootstrap
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();