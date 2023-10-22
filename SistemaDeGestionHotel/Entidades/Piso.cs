using System;
using System.Collections.Generic;

namespace SistemaDeGestionHotel.LO;

public partial class Piso
{
    public int IdPiso { get; set; }

    public int NroPiso { get; set; }

    public virtual ICollection<Habitacion> Habitacions { get; set; } = new List<Habitacion>();
}
