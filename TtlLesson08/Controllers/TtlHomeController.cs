using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TtlLesson08.Models;

namespace TtlLesson08.Controllers
{
	public class TtlHomeController : Controller
	{
	private readonly ILogger<TtlHomeController> _logger;
	public TtlHomeController(ILogger<TtlHomeController> logger)
	{
		_logger = logger;
	}
		public IActionResult TtlIndex()
		{
			return View();
		}

		public IActionResult TtlPrivacy()
		{
			return View();
		}
		public IActionResult TtlAbout()
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
