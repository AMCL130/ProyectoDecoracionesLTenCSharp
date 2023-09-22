using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DecoracionesLTv4.Models;

public partial class DecoracionesLtContext : IdentityDbContext
{
    public DecoracionesLtContext()
    {
    }

    public DecoracionesLtContext(DbContextOptions<DecoracionesLtContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Ingrediente> Ingredientes { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-FRMATRC;Initial Catalog=DecoracionesLT; integrated security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK_id");

            entity.ToTable("categorias");

            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente);

            entity.ToTable("cliente");

            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.Cedula).HasColumnName("cedula");
            entity.Property(e => e.Direccion)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombre).HasColumnName("nombre");
            entity.Property(e => e.Telefono).HasColumnName("telefono");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<Ingrediente>(entity =>
        {
            entity.HasKey(e => e.IdIngrediente).HasName("PK_ingredient");

            entity.ToTable("ingredientes");

            entity.Property(e => e.IdIngrediente).HasColumnName("id_ingrediente");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio).HasColumnName("precio");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK_productos");

            entity.ToTable("producto");

            entity.Property(e => e.IdProducto).HasColumnName("idProducto");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio).HasColumnName("precio");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.IdServicio).HasName("PK_servicios");

            entity.ToTable("servicio");

            entity.Property(e => e.IdServicio).HasColumnName("idServicio");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio).HasColumnName("precio");
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("PK_venta");

            entity.ToTable("ventas");

            entity.Property(e => e.IdVenta).HasColumnName("id_venta");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("fechaCreacion");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio).HasColumnName("precio");
            base.OnModelCreating(modelBuilder);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
