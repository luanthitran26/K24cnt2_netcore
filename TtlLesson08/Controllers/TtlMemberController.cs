using Microsoft.AspNetCore.Mvc;
using TtlLesson08.Models;

namespace TtlLesson08.Controllers
{
	public class TtlMemberController : Controller
	{
		// mock data -ttlmember
		private static List<TtlMember> _members = new List<TtlMember>()
		{
			new TtlMember
			{
				TtlMemberId = Guid.NewGuid().ToString(),
				TtlUserName = "Trần Luận",
				TtlPassword = "160626",
				TtlFullname = "Trần Thị Luận",
				TtlEmail = "luanthitran26@gmail.com"
			},

			new TtlMember
			{
				TtlMemberId = Guid.NewGuid().ToString(),
				TtlUserName = "tranthibinh",
				TtlPassword = "123456",
				TtlFullname = "Trần Thị Bình",
				TtlEmail = "tranthibinh@gmail.com"
			},

			new TtlMember
			{
				TtlMemberId = Guid.NewGuid().ToString(),
				TtlUserName = "levancuong",
				TtlPassword = "123456",
				TtlFullname = "Lê Văn Cường",
				TtlEmail = "levancuong@gmail.com"
			},

			new TtlMember
			{
				TtlMemberId = Guid.NewGuid().ToString(),
				TtlUserName = "phamthiduyen",
				TtlPassword = "123456",
				TtlFullname = "Phạm Thị Duyên",
				TtlEmail = "phamthiduyen@gmail.com"
			},

			new TtlMember
			{
				TtlMemberId = Guid.NewGuid().ToString(),
				TtlUserName = "hoangminhduc",
				TtlPassword = "123456",
				TtlFullname = "Hoàng Minh Đức",
				TtlEmail = "hoangminhduc@gmail.com"
			}
		};
		// get: danh sách  thành viên
		public IActionResult Index()
		{
			return View(_members);
		}
		[HttpGet]
		public IActionResult TtlCreate()
		{
			var member = new TtlMember();
			return View(); 
		}
		[HttpPost]
		public IActionResult TtlCreate(TtlMember ttlMember)
		{
			ttlMember.TtlMemberId = Guid.NewGuid().ToString();
			_members.Add(ttlMember);
			return RedirectToAction("Index");
			//return View(ttlMember);
		}
		public IActionResult TtlEdit(string id)
		{
			var member = _members.Where(x=>x.TtlMemberId.EndsWith(id)).FirstOrDefault();
			return View();
		}
		[HttpPost]
		public IActionResult TtlEdit(string id, TtlMember ttlMember)
		{
			//var member = _members.Where(x => x.TtlMemberId.EndsWith(id)).FirstOrDefault();
			for(int i=0; i<_members.Count;i++)
			{
				if (_members[i].TtlMemberId == id)
				{
					_members[i].TtlUserName = ttlMember.TtlUserName;
					_members[i].TtlPassword = ttlMember.TtlPassword;
					_members[i].TtlFullname = ttlMember.TtlFullname;
					_members[i].TtlEmail = ttlMember.TtlEmail;

					return RedirectToAction("Index");
				}

			}
			return View();
			
		}
		[HttpGet]
		public IActionResult TtlDetails(string id)
		{
			var member = _members.Where(x => x.TtlMemberId == id).FirstOrDefault();
			return View(member);
		}
	}
}
