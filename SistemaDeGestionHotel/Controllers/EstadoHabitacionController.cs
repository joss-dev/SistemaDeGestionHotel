using SistemaDeGestionHotel.Datos;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Controllers
{
    public class EstadoHabitacionController
    {
        DEstadoHabitacion d_estadoHabitacion = new DEstadoHabitacion();

        public bool AgregarEstadoHabitacion(string nombEstado)
        {
            EstadoHabitacion estadoHabitacion = new EstadoHabitacion()
            {
                NombEstado = nombEstado
            };

            return d_estadoHabitacion.AgregarEstadoHabitacion(estadoHabitacion);
        }

        public List<EstadoHabitacion> GetEstadosHabitaciones()
        {
            return d_estadoHabitacion.GetEstadosHabitaciones();
        }

        public EstadoHabitacion GetEstadoHabitacionByID(int id)
        {
            return d_estadoHabitacion.GetEstadoHabitacionByID(id);
        }

        public bool EditarEstadoHabitacion(int idEstado, string nombEstado)
        {
            EstadoHabitacion estadoExistente = d_estadoHabitacion.GetEstadoHabitacionByID(idEstado);

            if (estadoExistente == null)
            {
                // El estado de la habitación no existe, por lo tanto no se puede editar
                return false;
            }

            // El estado de la habitación existe, actualiza sus propiedades
            estadoExistente.NombEstado = nombEstado;

            d_estadoHabitacion.GuardarCambios();

            return true;
        }
    }
}
