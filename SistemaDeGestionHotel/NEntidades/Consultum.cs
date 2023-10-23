using System;
using System.Collections.Generic;

namespace SistemaDeGestionHotel.NEntidades;

public partial class Consultum
{
    public int IdConsulta { get; set; }

    public string Email { get; set; } = null!;

    public string Asunto { get; set; } = null!;

    public string Mensaje { get; set; } = null!;

    public DateTime FechaMensaje { get; set; }

    public int Estado { get; set; }

    public int IdUsuario { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
