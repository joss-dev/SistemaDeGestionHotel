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

        public Habitacion GetHabitacionByNroHabitacion(int nroHabitacion)
        {
            return d_habitacion.GetHabitacionByNroHabitacion(nroHabitacion);
        }

        public List<Habitacion> GetHabitaciones()
        {
            return d_habitacion.GetHabitaciones();
        }

        public Habitacion GetHabitacionByID(int iddehabitacion)
        {
            return d_habitacion.GetHabitacionByID(iddehabitacion);
        }

        public List<Habitacion> GetHabitacionesByNroPiso(int nroPiso)
        {
            return d_habitacion.GetHabitacionesByNroPiso(nroPiso);
        }

        public List<Habitacion> GetHabitacionesByEstado(int idEstado)
        {
            return d_habitacion.GetHabitacionesByEstado(idEstado);
        }

        public List<Habitacion> GetHabitacionesByTipoHabitacion(int idTipo)
        {
            return d_habitacion.GetHabitacionesByTipoHabitacion(idTipo);
        }

        public bool EditarHabitacion(int idHabitacion, int nrodehabitacion, int cantidaddecamas, float precio, int id_estado, int id_tipohab, int id_piso)
        {
            Habitacion habitacionExistente = d_habitacion.GetHabitacionByID(idHabitacion);

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

        public bool DeshabilitarHabitacion(int idHabitacion)
        {
            Habitacion habitacionExistente = d_habitacion.GetHabitacionByID(idHabitacion);

            if (habitacionExistente == null)
            {
                // La habitación no existe, por lo tanto no se puede editar
                return false;
            }

            habitacionExistente.IdEstado = 4;

            d_habitacion.GuardarCambios();

            return true;
        }

        public bool AltaHabitacion(int idHabitacion)
        {
            Habitacion habitacionExistente = d_habitacion.GetHabitacionByID(idHabitacion);

            if (habitacionExistente == null)
            {
                // La habitación no existe, por lo tanto no se puede editar
                return false;
            }

            habitacionExistente.IdEstado = 1;

            d_habitacion.GuardarCambios();

            return true;
        }

        public bool BajaHabitacion(int idHabitacion)
        {
            Habitacion habitacionExistente = d_habitacion.GetHabitacionByID(idHabitacion);

            if (habitacionExistente == null)
            {
                // La habitación no existe, por lo tanto no se puede editar
                return false;
            }

            habitacionExistente.IdEstado = 5;

            d_habitacion.GuardarCambios();

            return true;
        }
        public bool MarcarOcupadaHabitacion(int idHabitacion)
        {
            Habitacion habitacionExistente = d_habitacion.GetHabitacionByID(idHabitacion);

            if (habitacionExistente == null)
            {
                // La habitación no existe, por lo tanto no se puede editar
                return false;
            }

            habitacionExistente.IdEstado = 2;

            d_habitacion.GuardarCambios();

            return true;
        }

        public bool LiberarHabitacion(int idHabitacion)
        {
            Habitacion habitacionExistente = d_habitacion.GetHabitacionByID(idHabitacion);

            if (habitacionExistente == null)
            {
                // La habitación no existe, por lo tanto no se puede editar
                return false;
            }

            habitacionExistente.IdEstado = 1;

            d_habitacion.GuardarCambios();

            return true;
        }

        public bool MarcarReservadaHabitacion(int idHabitacion)
        {
            Habitacion habitacionExistente = d_habitacion.GetHabitacionByID(idHabitacion);

            if (habitacionExistente == null)
            {
                // La habitación no existe, por lo tanto no se puede editar
                return false;
            }

            habitacionExistente.IdEstado = 3;

            d_habitacion.GuardarCambios();

            return true;
        }

    }
}

