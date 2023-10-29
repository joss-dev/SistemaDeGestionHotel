using System;
using System.Collections.Generic;

namespace SistemaDeGestionHotel.NEntidades;

public partial class Habitacion
{
    public int IdHabitacion { get; set; }

    public int NroHabitacion { get; set; }

    public int CantidadCamas { get; set; }

    public double Precio { get; set; }

    public int IdEstado { get; set; }

    public int IdTipoHab { get; set; }

    public int IdPiso { get; set; }

    public virtual EstadoHabitacion IdEstadoNavigation { get; set; } = null!;

    public virtual Piso IdPisoNavigation { get; set; } = null!;

    public virtual TipoHabitacion IdTipoHabNavigation { get; set; } = null!;

    public virtual ICollection<Registro> Registros { get; set; } = new List<Registro>();
}
