using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeGestionHotel.NEntidades;

public partial class DetalleServicio
{
    [Key, Column(Order = 0)]
    [ForeignKey("IdRegistroNavigation")]
    public int IdRegistro { get; set; }

    [Key, Column(Order = 1)]
    [ForeignKey("IdServicioAdicNavigation")]
    public int IdServicioAdic { get; set; }

    public virtual Registro IdRegistroNavigation { get; set; } = null!;

    public virtual ServiciosAdicionale IdServicioAdicNavigation { get; set; } = null!;
}
