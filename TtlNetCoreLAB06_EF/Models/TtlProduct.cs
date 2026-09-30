using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TtlNetCoreLAB06_EF.Models;

[Table("TtlProduct")]
public partial class TtlProduct
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string TtlId { get; set; } = null!;

    [StringLength(100)]
    public string TtlName { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TtlPrice { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TtlSalePrice { get; set; }

    [StringLength(50)]
    public string TtlStatus { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TtlCreateDate { get; set; }

    [StringLength(255)]
    public string? TtlImages { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TtlCategoryId { get; set; }

    [StringLength(500)]
    public string? TtlDescription { get; set; }
}
