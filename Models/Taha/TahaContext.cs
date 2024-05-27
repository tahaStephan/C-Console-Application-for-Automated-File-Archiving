using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Teknoser_Log_Zipper.Models.Taha;

public partial class TahaContext : DbContext
{
    public TahaContext()
    {
    }

    public TahaContext(DbContextOptions<TahaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Second> Second { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer("Server=(localdb)\\ServerDetails;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Second>(entity =>
        {
            entity.HasKey("ID");

            entity.Property(e => e.Sayi).HasColumnName("sayi");
            entity.Property(e => e.Yazi)
                .HasColumnType("text")
                .HasColumnName("yazi");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
