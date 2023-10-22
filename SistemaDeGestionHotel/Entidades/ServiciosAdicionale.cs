using System;
using System.Collections.Generic;

namespace SistemaDeGestionHotel.LO;

public partial class ServiciosAdicionale
{
    public int IdServicioAdic { get; set; }

    public string NombServicio { get; set; } = null!;

    public double Precio { get; set; }

    public int Estado { get; set; }
}
