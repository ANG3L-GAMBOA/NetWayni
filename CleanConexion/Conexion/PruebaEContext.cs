using System;
using System.Collections.Generic;
using CleanModels;
using Microsoft.EntityFrameworkCore;

namespace CleanConexion.Conexion;

public partial class PruebaEContext : DbContext
{
    public PruebaEContext()
    {
    }

    public PruebaEContext(DbContextOptions<PruebaEContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3214EC07250FD816");

            entity.HasIndex(e => e.Dni, "UC_DNI").IsUnique();

            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Dni)
                .HasMaxLength(8)
                .HasColumnName("DNI");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
