using SistemaDeGestionHotel.Datos;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Controllers
{
    public class HabitacionController
    {
        DHabitacion d_habitacion = new DHabitacion();

        public bool AgregarHabitacion(int nrodehabitacion, int cantidaddecamas, float precio, int id_estado, int id_tipohab, int id_piso)
        {
            Habitacion habitacion = new Habitacion()
            {
                NroHabitacion = nrodehabitacion,
                CantidadCamas = cantidaddecamas,
                Precio = precio,
                IdEstado = id_estado,
                IdTipoHab = id_tipohab,
                IdPiso = id_piso
            };

            return d_habitacion.AgregarHabitacion(habitacion);
        }

        public List<Habitacion> GetHabitaciones()
        {
            return d_habitacion.GetHabitaciones();
        }

        public Habitacion GetHabitacionByNro(int nrodehabitacion)
        {
            return d_habitacion.GetHabitacionByNro(nrodehabitacion);
        }

        public bool EditarHabitacion(int idHabitacion, int nrodehabitacion, int cantidaddecamas, float precio, int id_estado, int id_tipohab, int id_piso)
        {
            Habitacion habitacionExistente = d_habitacion.GetHabitacionByNro(idHabitacion);

            if (habitacionExistente == null)
            {
                // La habitación no existe, por lo tanto no se puede editar
                return false;
            }

            // La habitación existe, actualiza sus propiedades
            habitacionExistente.NroHabitacion = nrodehabitacion;
            habitacionExistente.CantidadCamas = cantidaddecamas;
            habitacionExistente.Precio = precio;
            habitacionExistente.IdEstado = id_estado;
            habitacionExistente.IdTipoHab = id_tipohab;
            habitacionExistente.IdPiso = id_piso;

            d_habitacion.GuardarCambios();

            return true;
        }

        public bool BajaHabitacion(int idHabitacion)
        {
            Habitacion habitacionExistente = d_habitacion.GetHabitacionByNro(idHabitacion);

            if (habitacionExistente == null)
            {
                // La habitación no existe, por lo tanto no se puede editar
                return false;
            }

            habitacionExistente.IdEstadoNavigation.IdEstado = 4;

            d_habitacion.GuardarCambios();

            return true;
        }
    }
}

