using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Datos
{
    internal class DTipoMedioPago
    {
        private HotelParanaContext dbHotelParana;

        public DTipoMedioPago()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public bool AgregarTipoMedioPago(TipoMedioPago tipo)
        {
            bool result = true;
            try
            {
                // Intenta insertar el nuevo tipo de medio de pago en la base de datos
                dbHotelParana.Add(tipo);
                dbHotelParana.SaveChanges();
                return result;
            }
            catch (DbUpdateException ex)
            {
                result = false;
                return result;
            }
        }

        public List<TipoMedioPago> GetTiposMediosPagos()
        {
            return dbHotelParana.TipoMedioPagos.ToList();
        }

        public TipoMedioPago GetTipoMedioPagoByID(int id)
        {
            return dbHotelParana.TipoMedioPagos
                                 .FirstOrDefault(t => t.IdTipoMedioPago == id);
        }

        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }
    }
}
