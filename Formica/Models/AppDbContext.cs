using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Formica.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Agenda> Agenda { get; set; }

    public virtual DbSet<Progetti> Progettis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=Database/formica.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Agenda>(entity =>
        {
            entity.HasKey(e => e.IdAgenda);

            entity.Property(e => e.IdAgenda).ValueGeneratedOnAdd();
            entity.Property(e => e.DataEvento).HasColumnType("DATETIME");
        });

        modelBuilder.Entity<Progetti>(entity =>
        {
            entity.HasKey(e => e.IdProgetto);

            entity.ToTable("Progetti");

            entity.Property(e => e.DataApertura).HasColumnType("DATETIME");
            entity.Property(e => e.DataChiusura).HasColumnType("DATETIME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
