using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LvtLesson09Annotatioon.Models.DataViewModels
{
	// Data Annotation - Validation
	public class TtlMemberRegister
	{
         
        public int TtlMemberId { get; set; }

		[DisplayName("Tên đăng nhập")]
		[Required(ErrorMessage = "Tên đăng nhập không để trống")]
		[StringLength(20,MinimumLength = 3,ErrorMessage  = "Tên đăng nhập có độ dài trong khoản 2 - 20 ký tự")]
		public string TtlUserName { get; set; }
		[DisplayName("Mật khẩu")]
		[Required(ErrorMessage = "Mật khẩu không được để trống")]
		[DataType(DataType.Password)]
		public string TtlPassword { get; set; }
		public string TtlEmail { get; set; }
		public string TtlPhoneNumber { get; set; }
		public string TtlFullName { get; set; }
		public string TtlBirthday { get; set; }
	}
}
