using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TtlLesson11.Models;

public partial class TtlEmployeesLesson11Context : DbContext
{
    public TtlEmployeesLesson11Context()
    {
    }

    public TtlEmployeesLesson11Context(DbContextOptions<TtlEmployeesLesson11Context> options)
        : base(options)
    {
    }

    public virtual DbSet<TtlEmployee> TtlEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=TRANTHILUAN\\SQLEXPRESS01;Database=TtlEmployeesLesson11;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TtlEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TtlEmplo__3214EC0797C2A67E");

            entity.Property(e => e.TtlActive).HasDefaultValue(true);
            entity.Property(e => e.TtlEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TtlGender).HasMaxLength(10);
            entity.Property(e => e.TtlName).HasMaxLength(50);
            entity.Property(e => e.TtlPhone)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
