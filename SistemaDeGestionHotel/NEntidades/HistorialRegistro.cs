using System;
using System.Collections.Generic;

namespace SistemaDeGestionHotel.NEntidades;

public partial class HistorialRegistro
{
    public int IdHistorial { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int IdRegistro { get; set; }

    public int IdPago { get; set; }

    public virtual Pago IdPagoNavigation { get; set; } = null!;

    public virtual Registro IdRegistroNavigation { get; set; } = null!;
}
