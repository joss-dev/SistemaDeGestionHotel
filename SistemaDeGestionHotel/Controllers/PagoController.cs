using SistemaDeGestionHotel.Datos;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Controllers
{
    public class PagoController
    {
        DPago d_pago = new DPago();

        public bool AgregarPago(double montoPago, DateTime fechaPago, int estadoPago, int idOfertaRecargo, int idRegistro, int idMedioPago)
        {
            Pago pago = new Pago()
            {
                MontoPago = montoPago,
                FechaHoraPago = fechaPago,
                EstadoPago = estadoPago,
                IdOfertaRecargo = idOfertaRecargo,
                IdRegistro = idRegistro,
                IdMedioPago = idMedioPago
            };

            return d_pago.AgregarPago(pago);
        }

        public List<Pago> GetPagos()
        {
            return d_pago.GetPagos();
        }

        public Pago GetPagoByID(int id)
        {
            return d_pago.GetPagoByID(id);
        }

        public bool EditarPago(int idPago, double montoPago, DateTime fechaPago, int estadoPago, int idOfertaRecargo, int idRegistro, int idMedioPago)
        {
            Pago pagoExistente = d_pago.GetPagoByID(idPago);

            if (pagoExistente == null)
            {
                // El pago no existe, por lo tanto no se puede editar
                return false;
            }

            // El pago existe, actualiza sus propiedades
            pagoExistente.MontoPago = montoPago;
            pagoExistente.FechaHoraPago = fechaPago;
            pagoExistente.EstadoPago = estadoPago;
            pagoExistente.IdOfertaRecargo = idOfertaRecargo;
            pagoExistente.IdRegistro = idRegistro;
            pagoExistente.IdMedioPago = idMedioPago;

            d_pago.GuardarCambios();

            return true;
        }
        public bool BajaPago(int idPago)
        {
            Pago pagoExistente = d_pago.GetPagoByID(idPago);

            if (pagoExistente == null)
            {
                // La habitación no existe, por lo tanto no se puede editar
                return false;
            }

            pagoExistente.EstadoPago = 0;

            d_pago.GuardarCambios();

            return true;
        }
    }
}
