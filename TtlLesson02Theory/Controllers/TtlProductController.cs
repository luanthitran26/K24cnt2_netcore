using Microsoft.AspNetCore.Mvc;
using TtlLesson02Theory.Models;

namespace TtlLesson02Theory.Controllers
{
	public class TtlProductController : Controller
	{
		public IActionResult TtlIndex()
		{
		// dữ liệu trong đối tượng: ViewBag; Data; TempData
			ViewBag.name = "Trần Thị Luận";
			ViewData["productVD"] = "Lenovo";
			TempData["UNI"] = "Trường đại học Nguyễn Trãi - NTU";
			return View();
		}

		public IActionResult GetProduct()
		{
			TtlProduct ttlProduct = new TtlProduct() 
			{
				ProductId = "2410900049",
				ProductName =" Trần Thị Luận",
				YearRelease = 2006,
				price = 1000,
			};

			ViewBag .ttlProduct = ttlProduct;
			ViewData["product"] = ttlProduct;
			return View("product");
		}
	}
}
