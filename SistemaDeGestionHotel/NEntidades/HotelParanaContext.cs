using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SistemaDeGestionHotel.NEntidades;

public partial class HotelParanaContext : DbContext
{
    public HotelParanaContext()
    {
    }

    public HotelParanaContext(DbContextOptions<HotelParanaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Consultum> Consulta { get; set; }

    public virtual DbSet<DetalleServicio> DetalleServicios { get; set; }

    public virtual DbSet<EstadoHabitacion> EstadoHabitacions { get; set; }

    public virtual DbSet<Habitacion> Habitacions { get; set; }

    public virtual DbSet<MediosPago> MediosPagos { get; set; }

    public virtual DbSet<OfertasRecargo> OfertasRecargos { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<PerfilUsuario> PerfilUsuarios { get; set; }

    public virtual DbSet<Piso> Pisos { get; set; }

    public virtual DbSet<Registro> Registros { get; set; }

    public virtual DbSet<ServiciosAdicionale> ServiciosAdicionales { get; set; }

    public virtual DbSet<TipoHabitacion> TipoHabitacions { get; set; }

    public virtual DbSet<TipoMedioPago> TipoMedioPagos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-G7GUADO\\SQLEXPRESS;Database=HotelParana;Integrated Security=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK_ID_cliente");

            entity.ToTable("Cliente");

            entity.HasIndex(e => e.DniCliente, "UQ_DNI_cliente").IsUnique();

            entity.Property(e => e.IdCliente).HasColumnName("ID_cliente");
            entity.Property(e => e.ApellidoCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Apellido_cliente");
            entity.Property(e => e.DniCliente).HasColumnName("DNI_cliente");
            entity.Property(e => e.Estado).HasDefaultValueSql("((1))");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_cliente");
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Consultum>(entity =>
        {
            entity.HasKey(e => e.IdConsulta).HasName("PK_ID_consulta");

            entity.Property(e => e.IdConsulta).HasColumnName("ID_consulta");
            entity.Property(e => e.Asunto)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValueSql("((1))");
            entity.Property(e => e.FechaMensaje)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("Fecha_mensaje");
            entity.Property(e => e.IdUsuario).HasColumnName("ID_usuario");
            entity.Property(e => e.Mensaje).IsUnicode(false);

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Consulta)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ID_usuarioCons");
        });

        modelBuilder.Entity<DetalleServicio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Detalle_Servicios");

            entity.Property(e => e.IdRegistro).HasColumnName("ID_registro");
            entity.Property(e => e.IdServicioAdic).HasColumnName("ID_servicioAdic");

            entity.HasOne(d => d.IdRegistroNavigation).WithMany()
                .HasForeignKey(d => d.IdRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ID_registro");

            entity.HasOne(d => d.IdServicioAdicNavigation).WithMany()
                .HasForeignKey(d => d.IdServicioAdic)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ID_servicioAdic");
        });

        modelBuilder.Entity<EstadoHabitacion>(entity =>
        {
            entity.HasKey(e => e.IdEstado).HasName("PK_ID_estado");

            entity.ToTable("Estado_habitacion");

            entity.Property(e => e.IdEstado).HasColumnName("ID_estado");
            entity.Property(e => e.NombEstado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nomb_estado");
        });

        modelBuilder.Entity<Habitacion>(entity =>
        {
            entity.HasKey(e => e.NroHabitacion).HasName("PK_Nro_habitacion");

            entity.ToTable("Habitacion");

            entity.Property(e => e.NroHabitacion).HasColumnName("Nro_habitacion");
            entity.Property(e => e.CantidadCamas).HasColumnName("Cantidad_camas");
            entity.Property(e => e.IdEstado).HasColumnName("ID_estado");
            entity.Property(e => e.IdPiso).HasColumnName("ID_piso");
            entity.Property(e => e.IdTipoHab).HasColumnName("ID_tipoHab");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Habitacions)
                .HasForeignKey(d => d.IdEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ID_estado");

            entity.HasOne(d => d.IdPisoNavigation).WithMany(p => p.Habitacions)
                .HasForeignKey(d => d.IdPiso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ID_piso");

            entity.HasOne(d => d.IdTipoHabNavigation).WithMany(p => p.Habitacions)
                .HasForeignKey(d => d.IdTipoHab)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ID_tipoHab");
        });

        modelBuilder.Entity<MediosPago>(entity =>
        {
            entity.HasKey(e => e.IdMedioPago).HasName("PK_ID_medio_pago");

            entity.ToTable("Medios_pago");

            entity.Property(e => e.IdMedioPago).HasColumnName("ID_medio_pago");
            entity.Property(e => e.Estado).HasDefaultValueSql("((1))");
            entity.Property(e => e.IdTipoMedioPago).HasColumnName("ID_tipo_medioPago");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdTipoMedioPagoNavigation).WithMany(p => p.MediosPagos)
                .HasForeignKey(d => d.IdTipoMedioPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ID_tipo_medioPago");
        });

        modelBuilder.Entity<OfertasRecargo>(entity =>
        {
            entity.HasKey(e => e.IdOfertaRecargo).HasName("PK_ID_ofertaRecargo");

            entity.ToTable("Ofertas_recargo");

            entity.Property(e => e.IdOfertaRecargo).HasColumnName("ID_ofertaRecargo");
            entity.Property(e => e.Estado).HasDefaultValueSql("((1))");
            entity.Property(e => e.FechaDesde)
                .HasColumnType("date")
                .HasColumnName("Fecha_desde");
            entity.Property(e => e.FechaHasta)
                .HasColumnType("date")
                .HasColumnName("Fecha_hasta");
            entity.Property(e => e.NombOfertaRecargo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nomb_ofertaRecargo");
            entity.Property(e => e.PorcentajeDescuento).HasColumnName("Porcentaje_descuento");
            entity.Property(e => e.PorcentajeRecargo).HasColumnName("Porcentaje_recargo");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.IdPago).HasName("PK_ID_pago");

            entity.ToTable("Pago");

            entity.Property(e => e.IdPago).HasColumnName("ID_pago");
            entity.Property(e => e.EstadoPago)
                .HasDefaultValueSql("((1))")
                .HasColumnName("Estado_pago");
            entity.Property(e => e.FechaHoraPago)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_horaPago");
            entity.Property(e => e.IdMedioPago).HasColumnName("ID_medio_pago");
            entity.Property(e => e.IdOfertaRecargo).HasColumnName("ID_ofertaRecargo");
            entity.Property(e => e.IdRegistro).HasColumnName("ID_registro");
            entity.Property(e => e.MontoPago).HasColumnName("Monto_pago");

            entity.HasOne(d => d.IdMedioPagoNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.IdMedioPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ID_medio_pago");

            entity.HasOne(d => d.IdOfertaRecargoNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.IdOfertaRecargo)
                .HasConstraintName("FK_ID_ofertaRecargo");

            entity.HasOne(d => d.IdRegistroNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.IdRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ID_registro_pago");
        });

        modelBuilder.Entity<PerfilUsuario>(entity =>
        {
            entity.HasKey(e => e.IdPerfilUsuario).HasName("PK_ID_perfil_usuario");

            entity.ToTable("Perfil_usuario");

            entity.Property(e => e.IdPerfilUsuario).HasColumnName("ID_perfil_usuario");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Piso>(entity =>
        {
            entity.HasKey(e => e.IdPiso).HasName("PK_ID_piso");

            entity.ToTable("Piso");

            entity.Property(e => e.IdPiso).HasColumnName("ID_piso");
            entity.Property(e => e.NroPiso).HasColumnName("Nro_piso");
        });

        modelBuilder.Entity<Registro>(entity =>
        {
            entity.HasKey(e => e.IdRegistro).HasName("PK_ID_registro");

            entity.ToTable("Registro");

            entity.Property(e => e.IdRegistro).HasColumnName("ID_registro");
            entity.Property(e => e.CantidadHuespedes).HasColumnName("Cantidad_huespedes");
            entity.Property(e => e.EstadoOcupacion).HasColumnName("Estado_ocupacion");
            entity.Property(e => e.FechaIngreso)
                .HasColumnType("date")
                .HasColumnName("Fecha_ingreso");
            entity.Property(e => e.FechaSalida)
                .HasColumnType("date")
                .HasColumnName("Fecha_salida");
            entity.Property(e => e.IdCliente).HasColumnName("ID_cliente");
            entity.Property(e => e.IdUsuario).HasColumnName("ID_usuario");
            entity.Property(e => e.NroHabitacion).HasColumnName("Nro_habitacion");
            entity.Property(e => e.PrecioHabPactado).HasColumnName("Precio_HabPactado");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Registros)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ID_cliente");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Registros)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ID_usuario");

            entity.HasOne(d => d.NroHabitacionNavigation).WithMany(p => p.Registros)
                .HasForeignKey(d => d.NroHabitacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Nro_habitacion");
        });

        modelBuilder.Entity<ServiciosAdicionale>(entity =>
        {
            entity.HasKey(e => e.IdServicioAdic).HasName("PK_ID_servicioAdic");

            entity.ToTable("Servicios_adicionales");

            entity.Property(e => e.IdServicioAdic).HasColumnName("ID_servicioAdic");
            entity.Property(e => e.Estado).HasDefaultValueSql("((1))");
            entity.Property(e => e.NombServicio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nomb_servicio");
        });

        modelBuilder.Entity<TipoHabitacion>(entity =>
        {
            entity.HasKey(e => e.IdTipoHab).HasName("PK_ID_tipoHab");

            entity.ToTable("Tipo_habitacion");

            entity.Property(e => e.IdTipoHab).HasColumnName("ID_tipoHab");
            entity.Property(e => e.NombTipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nomb_tipo");
        });

        modelBuilder.Entity<TipoMedioPago>(entity =>
        {
            entity.HasKey(e => e.IdTipoMedioPago).HasName("PK_ID_tipo_medioPago");

            entity.ToTable("Tipo_medioPago");

            entity.Property(e => e.IdTipoMedioPago).HasColumnName("ID_tipo_medioPago");
            entity.Property(e => e.NombMedioPago)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nomb_medioPago");
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
            entity.Property(e => e.Estado).HasDefaultValueSql("((1))");
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
