using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Datos
{
    internal class DHabitacion
    {
        private HotelParanaContext dbHotelParana;

        public DHabitacion()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public bool AgregarHabitacion(Habitacion habitacion)
        {
            bool result = true;
            try
            {
                // Intenta insertar la nueva habitation en la base de datos
                dbHotelParana.Add(habitacion);
                dbHotelParana.SaveChanges();
                return result;
            }
            catch (DbUpdateException ex)
            {
                result = false;
                return result;
            }
        }

        public List<Habitacion> GetHabitaciones()
        {
            return dbHotelParana.Habitacions
                    .Include(c => c.IdEstadoNavigation)
                    .Include(c => c.IdTipoHabNavigation)
                    .ToList();
        }

        public Habitacion GetHabitacionByNro(int nrodehabitation)
        {
            return dbHotelParana.Habitacions
                                 .FirstOrDefault(h => h.NroHabitacion == nrodehabitation);
        }


        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }
    }
}
