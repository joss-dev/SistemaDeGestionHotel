using SistemaDeGestionHotel.Datos;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Controllers
{
    public class DetalleServicioController
    {
        DDetalleServicio d_detalleServicio = new DDetalleServicio();
        DServiciosAdicionales d_servicioAdicionales = new DServiciosAdicionales();
        DRegistro d_registro = new DRegistro();

        

        //public List<DetalleServicio> GetDetallesServicios()
        //{
        //    return d_detalleServicio.GetDetallesServicios();
        //}

        //falto el pk de esta tabla
        //public DetalleServicio GetDetalleServicioByID(int id)
        //{
        //    return d_detalleServicio.GetDetalleServicioByID(id);
        //}

        //public bool EditarDetalleServicio(int idDetalle, int idRegistro, int idServicioAdic)
        //{
        //    DetalleServicio detalleExistente = d_detalleServicio.GetDetalleServicioByID(idDetalle);

        //    if (detalleExistente == null)
        //    {
        //        // El detalle del servicio no existe, por lo tanto no se puede editar
        //        return false;
        //    }

        //    // El detalle del servicio existe, actualiza sus propiedades
        //    detalleExistente.IdRegistro = idRegistro;
        //    detalleExistente.IdServicioAdic = idServicioAdic;

        //    d_detalleServicio.GuardarCambios();

        //    return true;
        //}
    }
}
