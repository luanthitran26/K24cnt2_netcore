using Microsoft.EntityFrameworkCore;
using TtlLesson11.Models;


namespace TtlLesson11
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			var connectionString = builder.Configuration.GetConnectionString("TtlEmployeeLesson11Context")
				?? throw new InvalidOperationException(
					"Connection string 'TtlEmployeeLesson11Context' not found.");

			builder.Services.AddDbContext<TtlEmployeesLesson11Context>(options =>
				options.UseSqlServer(connectionString));

			builder.Services.AddControllersWithViews();

			var app = builder.Build();

			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
	