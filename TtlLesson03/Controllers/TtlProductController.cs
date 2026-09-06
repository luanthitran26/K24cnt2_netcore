using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TtlLesson03.Models;

namespace TtlLesson03.Controllers
{
	public class TtlProductController : Controller
	{
		//mock data
		private readonly List<TtlProduct> _products = new()
		{
			 new TtlProduct
	{
		TtlProductId = "SP001",
		TtlProductName = "iPhone 15",
		TtlYearRelease = 2023,
		TtlPrice = 18990000
	},
	new TtlProduct
	{
		TtlProductId = "SP002",
		TtlProductName = "iPhone 15 Pro Max",
		TtlYearRelease = 2023,
		TtlPrice = 29990000
	},
	new TtlProduct
	{
		TtlProductId = "SP003",
		TtlProductName = "Samsung Galaxy S24",
		TtlYearRelease = 2024,
		TtlPrice = 21990000
	},
	new TtlProduct
	{
		TtlProductId = "SP004",
		TtlProductName = "Samsung Galaxy S24 Ultra",
		TtlYearRelease = 2024,
		TtlPrice = 33990000
	},
	new TtlProduct
	{
		TtlProductId = "SP005",
		TtlProductName = "Xiaomi 14",
		TtlYearRelease = 2024,
		TtlPrice = 19990000
	},
	new TtlProduct
	{
		TtlProductId = "SP006",
		TtlProductName = "OPPO Reno 11",
		TtlYearRelease = 2024,
		TtlPrice = 10990000
	},
		 new TtlProduct
		{
		 TtlProductId = "SP007",
		 TtlProductName = "Vivo V30",
		 TtlYearRelease = 2024,
		 TtlPrice = 11990000
		},
		new TtlProduct
		{
		  TtlProductId = "SP008",
		  TtlProductName = "Google Pixel 8",
		  TtlYearRelease = 2023,
		  TtlPrice = 16990000
		},
		 new TtlProduct
		{
		  TtlProductId = "SP009",
		  TtlProductName = "Samsung Galaxy A55",
		  TtlYearRelease = 2024,
		  TtlPrice = 10990000
		},
		  new TtlProduct
		{
		  TtlProductId = "SP010",
		  TtlProductName = "OnePlus 12",
		  TtlYearRelease = 2024,
		  TtlPrice = 18990000
		}
		};
		public IActionResult Index()
		{
			return Json(_products);
		}
		// Collection => view
		public IActionResult TtlGetAllPoduct()
		{
			 ViewData["products"] = _products;
			 return View();	
		}
	}
}
