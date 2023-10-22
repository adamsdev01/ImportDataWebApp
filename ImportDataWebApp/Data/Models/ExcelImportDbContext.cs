using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ImportDataWebApp.Data.Models;

public partial class ExcelImportDbContext : DbContext
{
    public ExcelImportDbContext()
    {
    }

    public ExcelImportDbContext(DbContextOptions<ExcelImportDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Crimes2023> Crimes2023s { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Crimes2023>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Crimes20__3214EC2719624BF3");

            entity.ToTable("Crimes2023");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Beat)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Block)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CaseNumber)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CommunityArea)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.District)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Fbicode)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("FBICode");
            entity.Property(e => e.Iucr)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("IUCR");
            entity.Property(e => e.LocationDescription)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PrimaryType)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Xcoordinate).HasColumnName("XCoordinate");
            entity.Property(e => e.Ycoordinate).HasColumnName("YCoordinate");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
