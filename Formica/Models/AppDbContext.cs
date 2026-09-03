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

    public virtual DbSet<Agendum> Agenda { get; set; }

    public virtual DbSet<Progetti> Progettis { get; set; }

    public virtual DbSet<StatoLavorazione> StatoLavoraziones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=Database/formica.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agendum>(entity =>
        {
            entity.HasKey(e => e.IdAgenda);

            entity.Property(e => e.DataEvento).HasColumnType("datetime");
        });

        modelBuilder.Entity<Progetti>(entity =>
        {
            entity.HasKey(e => e.IdProgetto);

            entity.ToTable("Progetti");

            entity.Property(e => e.DataApertura).HasColumnType("DATETIME");
            entity.Property(e => e.DataChiusura).HasColumnType("DATETIME");
        });

        modelBuilder.Entity<StatoLavorazione>(entity =>
        {
            entity.HasKey(e => e.IdStato);

            entity.ToTable("StatoLavorazione");

            entity.Property(e => e.IdStato).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
