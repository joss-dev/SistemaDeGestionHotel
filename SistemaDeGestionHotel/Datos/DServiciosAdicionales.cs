using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Datos
{
    internal class DServiciosAdicionales
    {
        private HotelParanaContext dbHotelParana;

        public DServiciosAdicionales()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public bool AgregarServicioAdicional(ServiciosAdicionale servicio)
        {
            bool result = true;
            try
            {
                // Intenta insertar el nuevo servicio adicional en la base de datos
                dbHotelParana.Add(servicio);
                dbHotelParana.SaveChanges();
                return result;
            }
            catch (DbUpdateException ex)
            {
                result = false;
                return result;
            }
        }

        public List<ServiciosAdicionale> GetServiciosAdicionales()
        {
            return dbHotelParana.ServiciosAdicionales.ToList();
        }

        public ServiciosAdicionale GetServicioAdicionalByID(int id)
        {
            return dbHotelParana.ServiciosAdicionales
                                 .FirstOrDefault(s => s.IdServicioAdic == id);
        }

        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }
    }
}
