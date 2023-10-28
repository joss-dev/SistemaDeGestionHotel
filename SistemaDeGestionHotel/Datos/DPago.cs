using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Datos
{
    internal class DPago
    {
        private HotelParanaContext dbHotelParana;

        public DPago()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public bool AgregarPago(Pago pago)
        {
            bool result = true;
            try
            {
                // Intenta insertar el nuevo pago en la base de datos
                dbHotelParana.Add(pago);
                dbHotelParana.SaveChanges();
                return result;
            }
            catch (DbUpdateException ex)
            {
                result = false;
                return result;
            }
        }

        public List<Pago> GetPagos()
        {
            return dbHotelParana.Pagos.ToList();
        }

        public Pago GetPagoByID(int id)
        {
            return dbHotelParana.Pagos
                                 .FirstOrDefault(p => p.IdPago == id);
        }

        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }
    }
}
