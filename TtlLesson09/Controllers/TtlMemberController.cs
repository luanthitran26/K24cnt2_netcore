using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TtlLesson09.Models.DataModels;

namespace TtlLesson09.Controllers
{
	
	public class TtlMemberController : Controller
	{
		private static List<TtlMember> _ttlMembers = new List<TtlMember>();
		// GET: TtlMemberController
		public ActionResult Index()
		{
			return View(_ttlMembers);
		}

		// GET: TtlMemberController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: TtlMemberController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: TtlMemberController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: TtlMemberController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: TtlMemberController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: TtlMemberController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: TtlMemberController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
