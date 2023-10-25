using System;
using System.Collections.Generic;

namespace SistemaDeGestionHotel.NEntidades;

public partial class Pago
{
    public int IdPago { get; set; }

    public double MontoPago { get; set; }

    public DateTime FechaHoraPago { get; set; }

    public int EstadoPago { get; set; }

    public int? IdOfertaRecargo { get; set; }

    public int IdRegistro { get; set; }

    public int IdMedioPago { get; set; }

    public virtual MediosPago IdMedioPagoNavigation { get; set; } = null!;

    public virtual OfertasRecargo? IdOfertaRecargoNavigation { get; set; }

    public virtual Registro IdRegistroNavigation { get; set; } = null!;
}
