using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeGestionHotel.NEntidades;

public partial class DetalleServicio
{

    public int IdRegistro { get; set; }


    public int IdServicioAdic { get; set; }

    public virtual Registro IdRegistroNavigation { get; set; } = null!;

    public virtual ServiciosAdicionale IdServicioAdicNavigation { get; set; } = null!;
}
