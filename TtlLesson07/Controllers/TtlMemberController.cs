using Microsoft.AspNetCore.Mvc;
using TtlLesson07.Models.DataModels;

namespace TtlLesson07.Controllers
{
	public class TtlMemberController : Controller
	{
		protected List<TtlMember> _members = new List<TtlMember>
		{
					new TtlMember
			{
				TtlMemberId = Guid.NewGuid().ToString(),
				TtlUserName = "trần luận",
				TtlPassword = "2410900049",
				TtlFullname = "Trần Thị Luận",
				TtlEmail = "luanthitran26@gmail.com"
			},

			new TtlMember
			{
				TtlMemberId = Guid.NewGuid().ToString(),
				TtlUserName = "tranthib",
				TtlPassword = "123456",
				TtlFullname = "Trần Thị Bình",
				TtlEmail = "tranthib@gmail.com"
			},

			new TtlMember
			{
				TtlMemberId = Guid.NewGuid().ToString(),
				TtlUserName = "levanc",
				TtlPassword = "123456",
				TtlFullname = "Lê Văn Cường",
				TtlEmail = "levanc@gmail.com"
			},

			new TtlMember
			{
				TtlMemberId = Guid.NewGuid().ToString(),
				TtlUserName = "phamthid",
				TtlPassword = "123456",
				TtlFullname = "Phạm Thị Dung",
				TtlEmail = "phamthid@gmail.com"
			},

			new TtlMember
			{
				TtlMemberId = Guid.NewGuid().ToString(),
				TtlUserName = "hoangvane",
				TtlPassword = "123456",
				TtlFullname = "Hoàng Văn Đức",
				TtlEmail = "hoangvane@gmail.com"
			}

	};	
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult GetMember() 
		{
			var member = new Models.DataModels.TtlMember
			{
				TtlMemberId =Guid.NewGuid().ToString(),
				TtlUserName = "Trần Luận",
				TtlPassword = "password123",
				TtlEmail = "luanthitran16@gmail.com"
			};
			ViewBag.Member = member;
			return View();
		}
		// mô tả dạng dữ liệu List ra View
		public IActionResult GetMembers()
		{
		/// lấy từ mock data
			ViewBag.Member = _members;
			return View();
		}

	}
}
