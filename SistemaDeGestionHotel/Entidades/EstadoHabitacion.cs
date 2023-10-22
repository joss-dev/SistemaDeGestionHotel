using System;
using System.Collections.Generic;

namespace SistemaDeGestionHotel.LO;

public partial class EstadoHabitacion
{
    public int IdEstado { get; set; }

    public string NombEstado { get; set; } = null!;

    public virtual ICollection<Habitacion> Habitacions { get; set; } = new List<Habitacion>();
}
