﻿namespace SistemaDeGestionHotel.NEntidades;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int Dni { get; set; }

    public string CorreoElectronico { get; set; } = null!;

    public int Estado { get; set; }

    public string Direccion { get; set; } = null!;

    public string NombreUsuario { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public string FotoPerfil { get; set; } = null!;

    public int? IdPerfilUsuario { get; set; }

    public virtual ICollection<Consultum> Consulta { get; set; } = new List<Consultum>();

    public virtual PerfilUsuario? IdPerfilUsuarioNavigation { get; set; }

    public virtual ICollection<Registro> Registros { get; set; } = new List<Registro>();
}
