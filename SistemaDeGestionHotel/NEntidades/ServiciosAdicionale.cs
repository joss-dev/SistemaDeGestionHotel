namespace SistemaDeGestionHotel.NEntidades;

public partial class ServiciosAdicionale
{
    public int IdServicioAdic { get; set; }

    public string NombServicio { get; set; } = null!;

    public double Precio { get; set; }

    public int Estado { get; set; }

    public virtual ICollection<Registro> IdRegistros { get; set; } = new List<Registro>();
}
