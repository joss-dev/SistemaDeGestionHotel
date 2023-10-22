﻿using System;
using System.Collections.Generic;

namespace SistemaDeGestionHotel.LO;

public partial class TipoHabitacion
{
    public int IdTipoHab { get; set; }

    public string NombTipo { get; set; } = null!;

    public virtual ICollection<Habitacion> Habitacions { get; set; } = new List<Habitacion>();
}
