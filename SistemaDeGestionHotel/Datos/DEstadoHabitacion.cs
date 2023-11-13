using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Datos
{
    internal class DEstadoHabitacion
    {
        private HotelParanaContext dbHotelParana;

        public DEstadoHabitacion()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public bool AgregarEstadoHabitacion(EstadoHabitacion estado)
        {
            bool result = true;
            try
            {
                // Intenta insertar el nuevo estado de habitación en la base de datos
                dbHotelParana.Add(estado);
                dbHotelParana.SaveChanges();
                return result;
            }
            catch (DbUpdateException ex)
            {
                result = false;
                return result;
            }
        }

        public List<String> GetEstadosHabitaciones()
        {
            return dbHotelParana.EstadoHabitacions
                                 .Select(esthab => esthab.NombEstado)
                                .ToList();
        }

        public EstadoHabitacion GetEstadoHabitacionByID(int id)
        {
            return dbHotelParana.EstadoHabitacions
                                 .FirstOrDefault(e => e.IdEstado == id);
        }

        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }
    }
}
