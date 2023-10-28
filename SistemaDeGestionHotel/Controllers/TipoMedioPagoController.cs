using SistemaDeGestionHotel.Datos;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Controllers
{
    public class TipoMedioPagoController
    {
        DTipoMedioPago d_tipoMedioPago = new DTipoMedioPago();

        public bool AgregarTipoMedioPago(string nombMedioPago)
        {
            TipoMedioPago tipoMedioPago = new TipoMedioPago()
            {
                NombMedioPago = nombMedioPago
            };

            return d_tipoMedioPago.AgregarTipoMedioPago(tipoMedioPago);
        }

        public List<TipoMedioPago> GetTiposMediosPagos()
        {
            return d_tipoMedioPago.GetTiposMediosPagos();
        }

        public TipoMedioPago GetTipoMedioPagoByID(int id)
        {
            return d_tipoMedioPago.GetTipoMedioPagoByID(id);
        }

        public bool EditarTipoMedioPago(int idTipo, string nombMedioPago)
        {
            TipoMedioPago tipoExistente = d_tipoMedioPago.GetTipoMedioPagoByID(idTipo);

            if (tipoExistente == null)
            {
                // El tipo de medio de pago no existe, por lo tanto no se puede editar
                return false;
            }

            // El tipo de medio de pago existe, actualiza sus propiedades
            tipoExistente.NombMedioPago = nombMedioPago;

            d_tipoMedioPago.GuardarCambios();

            return true;
        }
    }
}
