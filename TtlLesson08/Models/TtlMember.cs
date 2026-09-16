using System.ComponentModel;

namespace TtlLesson08.Models
{
	public class TtlMember
	{
	public string TtlMemberId { get; set; }
	public string TtlUserName { get; set; }
	public string TtlPassword { get; set; }
	[DisplayName("Họ và tên")]
	public string TtlFullname { get; set; }
	public string TtlEmail { get; set; }
	}
}
