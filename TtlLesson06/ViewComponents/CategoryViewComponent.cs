using Microsoft.AspNetCore.Mvc;
using TtlLesson06.Models;
namespace TtlLesson06.ViewComponents
{
	public class CategoryViewComponent : ViewComponent
	{
		public IViewComponentResult Invole()
		{
			var categories = new List<Models.Category>
			{
				new Category{categoryId=1,categoryname ="Electronis", status = true},
				new Category{categoryId=2,categoryname ="Books", status = true},
				new Category{categoryId=3,categoryname ="Clothing", status = false},
				new Category{categoryId=4,categoryname ="Home & Kitchen", status = true}
			};
			return View(categories);
		}
	}
}
