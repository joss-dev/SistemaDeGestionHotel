using System;
using System.Collections.Generic;

namespace SistemaDeGestionHotel.NEntidades;

public partial class Registro
{
    public int IdRegistro { get; set; }

    public int CantidadHuespedes { get; set; }

    public double PrecioHabPactado { get; set; }

    public int EstadoOcupacion { get; set; }

    public DateTime FechaIngreso { get; set; }

    public DateTime FechaSalida { get; set; }

    public int IdUsuario { get; set; }

    public int NroHabitacion { get; set; }

    public int IdCliente { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual Habitacion NroHabitacionNavigation { get; set; } = null!;

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
