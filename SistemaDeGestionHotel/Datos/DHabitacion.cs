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

        public List<Habitacion> GetHabitacionesByNroPiso(int nroPiso)
        {
            // Obtener todas las habitaciones
            List<Habitacion> todasLasHabitaciones = dbHotelParana.Habitacions.Include(h => h.IdPisoNavigation).ToList();

            // Filtrar las habitaciones por el número de piso
            List<Habitacion> habitacionesFiltradas = todasLasHabitaciones.Where(h => h.IdPisoNavigation.NroPiso == nroPiso).ToList();

            return habitacionesFiltradas;
        }

        public List<Habitacion> GetHabitacionesByEstado(int idEstado)
        {
            // Obtener todas las habitaciones
            List<Habitacion> todasLasHabitaciones = dbHotelParana.Habitacions.Include(h => h.IdEstadoNavigation).ToList();

            // Filtrar las habitaciones por el número de piso
            List<Habitacion> habitacionesFiltradas = todasLasHabitaciones.Where(h => h.IdEstadoNavigation.IdEstado == idEstado).ToList();

            return habitacionesFiltradas;
        }

        public List<Habitacion> GetHabitacionesByTipoHabitacion(int idTipo)
        {
            // Obtener todas las habitaciones
            List<Habitacion> todasLasHabitaciones = dbHotelParana.Habitacions.Include(h => h.IdTipoHabNavigation).ToList();

            // Filtrar las habitaciones por el número de piso
            List<Habitacion> habitacionesFiltradas = todasLasHabitaciones.Where(h => h.IdTipoHabNavigation.IdTipoHab == idTipo).ToList();

            return habitacionesFiltradas;
        }

        public Habitacion GetHabitacionByID(int iddehabitation)
        {
            return dbHotelParana.Habitacions
                                 .FirstOrDefault(h => h.IdHabitacion == iddehabitation);
        }


        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }
    }
}
