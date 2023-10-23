using System;
using System.Collections.Generic;

namespace SistemaDeGestionHotel.NEntidades;

public partial class PerfilUsuario
{
    public int IdPerfilUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
