using System;
using System.Collections.Generic;

namespace SistemaDeGestionHotel.LO;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string ApellidoCliente { get; set; } = null!;

    public string NombreCliente { get; set; } = null!;

    public int DniCliente { get; set; }

    public string Telefono { get; set; } = null!;

    public virtual ICollection<Registro> Registros { get; set; } = new List<Registro>();
}
