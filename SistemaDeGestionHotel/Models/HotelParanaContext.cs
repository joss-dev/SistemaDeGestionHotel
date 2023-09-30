using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SistemaDeGestionHotel.Models;

public partial class HotelParanaContext : DbContext
{
    public HotelParanaContext()
    {
    }

    public HotelParanaContext(DbContextOptions<HotelParanaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PerfilUsuario> PerfilUsuarios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=LAPTOP-2ULFU3L6\\SQLEXPRESS;Database=HotelParana;Integrated Security=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PerfilUsuario>(entity =>
        {
            entity.HasKey(e => e.IdPerfilUsuario).HasName("PK_ID_perfil_usuario");

            entity.ToTable("Perfil_usuario");

            entity.Property(e => e.IdPerfilUsuario).HasColumnName("ID_perfil_usuario");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK_ID_usuario");

            entity.ToTable("Usuario");

            entity.HasIndex(e => e.CorreoElectronico, "UQ_Correo_electronico").IsUnique();

            entity.HasIndex(e => e.Dni, "UQ_DNI").IsUnique();

            entity.HasIndex(e => e.NombreUsuario, "UQ_Nombre_usuario").IsUnique();

            entity.Property(e => e.IdUsuario).HasColumnName("ID_usuario");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Contraseña)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Correo_electronico");
            entity.Property(e => e.Direccion)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.Dni).HasColumnName("DNI");
            entity.Property(e => e.FotoPerfil)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("Foto_perfil");
            entity.Property(e => e.IdPerfilUsuario).HasColumnName("ID_perfil_usuario");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_usuario");

            entity.HasOne(d => d.IdPerfilUsuarioNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdPerfilUsuario)
                .HasConstraintName("FK_Id_perfil_usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
