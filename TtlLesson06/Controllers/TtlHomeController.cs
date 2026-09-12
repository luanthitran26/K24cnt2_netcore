using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TtlLesson06.Models;

namespace TtlLesson06.Controllers
{
	public class TtlHomeController : Controller

	{
		private readonly ILogger<TtlHomeController> _logger;
		public TtlHomeController(ILogger<TtlHomeController> logger)
		{
			_logger = logger;
		}
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
