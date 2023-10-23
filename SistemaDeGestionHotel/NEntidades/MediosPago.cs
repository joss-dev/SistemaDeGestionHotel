using System;
using System.Collections.Generic;

namespace SistemaDeGestionHotel.NEntidades;

public partial class MediosPago
{
    public int IdMedioPago { get; set; }

    public string Nombre { get; set; } = null!;

    public int Estado { get; set; }

    public int IdTipoMedioPago { get; set; }

    public virtual TipoMedioPago IdTipoMedioPagoNavigation { get; set; } = null!;

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
