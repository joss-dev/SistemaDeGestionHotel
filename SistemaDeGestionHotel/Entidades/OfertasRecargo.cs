using System;
using System.Collections.Generic;

namespace SistemaDeGestionHotel.LO;

public partial class OfertasRecargo
{
    public int IdOfertaRecargo { get; set; }

    public string NombOfertaRecargo { get; set; } = null!;

    public DateTime FechaDesde { get; set; }

    public DateTime FechaHasta { get; set; }

    public int Estado { get; set; }

    public double? PorcentajeDescuento { get; set; }

    public double? PorcentajeRecargo { get; set; }

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
