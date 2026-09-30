using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TtlNetCoreLAB06_EF.Models;

namespace TtlNetCoreLAB06_EF.Data;

public partial class TtlProductDbContext : DbContext
{
    public TtlProductDbContext(DbContextOptions<TtlProductDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TtlProduct> TtlProducts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TtlProduct>(entity =>
        {
            entity.HasKey(e => e.TtlId).HasName("PK__TtlProdu__A867C0B7348C7F6E");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
