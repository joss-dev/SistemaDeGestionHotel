using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Datos
{
    internal class DMediosPago
    {
        private HotelParanaContext dbHotelParana;

        public DMediosPago()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public bool AgregarMedioPago(MediosPago medio_pago)
        {

            try
            {
                // Intenta insertar el nuevo medio de pagos en la base de datos
                dbHotelParana.Add(medio_pago);
                dbHotelParana.SaveChanges();
                return true;
            }
            catch (DbUpdateException ex)
            {
                // Considera registrar el error en algún lugar para poder depurarlo
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public MediosPago ObtenerMedioPagoPorID(int idMedioPago)
        {
            return dbHotelParana.MediosPagos.FirstOrDefault(c => c.IdMedioPago == idMedioPago); // Busca una consulta activa por ID
        }

        public List<MediosPago> ObtenerTodosLosMediosPago()
        {
            return dbHotelParana.MediosPagos
                                 .Include(c => c.IdTipoMedioPagoNavigation)
                                 .ToList();
        }

        /*public bool MarcarMPDesactivado(int MPId)
        {
            bool result = true;

            MediosPago medio_pago = ObtenerMedioPagoPorID(MPId);
            if (medio_pago != null)
            {
                medio_pago.Estado = 0; // Cambia el estado a "desactivado"
                dbHotelParana.SaveChanges(); // Guarda los cambios en la base de datos
                return result;
            }
            else
            {
                result = false;
                return result;
            }
        }*/

        public List<TipoMedioPago> ObtenerTiposMedioPago()
        {
            var medios_pago = dbHotelParana.MediosPagos
                .Select(tmp => tmp.IdTipoMedioPagoNavigation) // Carga la entidad Tipo de medios de pago relacionado relacionada
                .ToList();

            return medios_pago;
        }

        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }
    }
}
