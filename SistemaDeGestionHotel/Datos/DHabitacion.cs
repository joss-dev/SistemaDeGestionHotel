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
            // Obtener todas las habitaciones
            List<Habitacion> todasLasHabitaciones = dbHotelParana.Habitacions
                .Include(c => c.IdEstadoNavigation)
                .Include(c => c.IdTipoHabNavigation)
                .ToList();

            // Recargar cada entidad en todasLasHabitaciones desde la base de datos
            foreach (var habitacion in todasLasHabitaciones)
            {
                dbHotelParana.Entry(habitacion).Reload();
            }

            return todasLasHabitaciones;
        }

        public Habitacion GetHabitacionByNroHabitacion(int nroHabitacion)
        {
            this.ReloadAllEntities();
            return dbHotelParana.Habitacions
                                 .FirstOrDefault(h => h.NroHabitacion == nroHabitacion);
        }

        public List<Habitacion> GetHabitacionesByNroHabitacion(int nroHabitacion)
        {
            this.ReloadAllEntities();
            return dbHotelParana.Habitacions
                                 .Where(h => h.NroHabitacion == nroHabitacion)
                                 .ToList();
        }

        public List<Habitacion> GetHabitacionesByNroPiso(int nroPiso)
        {
            // Obtener todas las habitaciones
            List<Habitacion> todasLasHabitaciones = dbHotelParana.Habitacions.Include(h => h.IdPisoNavigation).ToList();

            // Filtrar las habitaciones por el número de piso
            List<Habitacion> habitacionesFiltradas = todasLasHabitaciones.Where(h => h.IdPisoNavigation.NroPiso == nroPiso).ToList();

            // Recarga cada entidad en habitacionesFiltradas desde la base de datos
            foreach (var habitacion in habitacionesFiltradas)
            {
                dbHotelParana.Entry(habitacion).Reload();
            }

            return habitacionesFiltradas;
        }


        public List<Habitacion> GetHabitacionesByEstado(int idEstado)
        {
            // Obtener todas las habitaciones
            List<Habitacion> todasLasHabitaciones = dbHotelParana.Habitacions.Include(h => h.IdEstadoNavigation).ToList();

            // Filtrar las habitaciones por el número de piso
            List<Habitacion> habitacionesFiltradas = todasLasHabitaciones.Where(h => h.IdEstadoNavigation.IdEstado == idEstado).ToList();

            // Recarga cada entidad en habitacionesFiltradas desde la base de datos
            foreach (var habitacion in habitacionesFiltradas)
            {
                dbHotelParana.Entry(habitacion).Reload();
            }

            return habitacionesFiltradas;
        }

        public List<Habitacion> GetHabitacionesByTipoHabitacion(int idTipo)
        {
            // Obtener todas las habitaciones
            List<Habitacion> todasLasHabitaciones = dbHotelParana.Habitacions.Include(h => h.IdTipoHabNavigation).ToList();

            // Filtrar las habitaciones por el número de piso
            List<Habitacion> habitacionesFiltradas = todasLasHabitaciones.Where(h => h.IdTipoHabNavigation.IdTipoHab == idTipo).ToList();

            // Recarga cada entidad en habitacionesFiltradas desde la base de datos
            foreach (var habitacion in habitacionesFiltradas)
            {
                dbHotelParana.Entry(habitacion).Reload();
            }

            return habitacionesFiltradas;
        }

        public void ReloadAllEntities()
        {
            var changedEntries = dbHotelParana.ChangeTracker.Entries()
                .Where(e => e.State != EntityState.Unchanged)
                .ToList();

            foreach (var entry in changedEntries)
            {
                entry.Reload();
            }
        }

        public Habitacion GetHabitacionByID(int iddehabitation)
        {
            this.ReloadAllEntities();
            return dbHotelParana.Habitacions
                                .Include(h => h.IdEstadoNavigation)   // Incluye la relación a IdEstadoNavigation
                                .Include(h => h.IdPisoNavigation)     // Incluye la relación a IdPisoNavigation
                                .Include(h => h.IdTipoHabNavigation)  // Incluye la relación a IdTipoHabNavigation
                                .FirstOrDefault(h => h.IdHabitacion == iddehabitation);
        }


        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }

        public void ActualizarDatos(Habitacion habitacion)
        {
            dbHotelParana.Update(habitacion);
        }
    }
}
