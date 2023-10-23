using System;
using System.Collections.Generic;

namespace SistemaDeGestionHotel.NEntidades;

public partial class TipoMedioPago
{
    public int IdTipoMedioPago { get; set; }

    public string NombMedioPago { get; set; } = null!;

    public virtual ICollection<MediosPago> MediosPagos { get; set; } = new List<MediosPago>();
}
