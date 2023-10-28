using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Datos
{
    internal class DDetalleServicio
    {
        private HotelParanaContext dbHotelParana;

        public DDetalleServicio()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public bool AgregarDetalleServicio(DetalleServicio detalle)
        {
            bool result = true;
            try
            {
                // Intenta insertar el nuevo detalle de servicio en la base de datos
                dbHotelParana.Add(detalle);
                dbHotelParana.SaveChanges();
                return result;
            }
            catch (DbUpdateException ex)
            {
                result = false;
                return result;
            }
        }

        public List<DetalleServicio> GetDetallesServicios()
        {
            return dbHotelParana.DetalleServicios.ToList();
        }

        //falto el pk enn esta tabla
        //public DetalleServicio GetDetalleServicioByID(int id)
        //{
        //    return dbHotelParana.DetalleServicios
        //                         .FirstOrDefault(d => d.Id == id);
        //}

        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }
    }
}
