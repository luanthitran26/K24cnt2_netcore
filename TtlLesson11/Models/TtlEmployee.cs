using System;
using System.Collections.Generic;

namespace TtlLesson11.Models;

public partial class TtlEmployee
{
    public long Id { get; set; }

    public string TtlName { get; set; } = null!;

    public string? TtlGender { get; set; }

    public DateOnly? TtlBirthDay { get; set; }

    public string? TtlEmail { get; set; }

    public string? TtlPhone { get; set; }

    public bool TtlActive { get; set; }
}
