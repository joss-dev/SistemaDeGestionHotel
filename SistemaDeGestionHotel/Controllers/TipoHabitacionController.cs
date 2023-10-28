using SistemaDeGestionHotel.Datos;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Controllers
{
    public class TipoHabitacionController
    {
        DTipoHabitacion d_tipoHabitacion = new DTipoHabitacion();

        public bool AgregarTipoHabitacion(string nombTipo)
        {
            TipoHabitacion tipoHabitacion = new TipoHabitacion()
            {
                NombTipo = nombTipo
            };

            return d_tipoHabitacion.AgregarTipoHabitacion(tipoHabitacion);
        }

        public List<TipoHabitacion> GetTiposHabitacion()
        {
            return d_tipoHabitacion.GetTiposHabitacion();
        }

        public TipoHabitacion GetTipoHabitacionByID(int id)
        {
            return d_tipoHabitacion.GetTipoHabitacionByID(id);
        }

        public bool EditarTipoHabitacion(int idTipo, string nombTipo)
        {
            TipoHabitacion tipoExistente = d_tipoHabitacion.GetTipoHabitacionByID(idTipo);

            if (tipoExistente == null)
            {
                // El tipo de habitación no existe, por lo tanto no se puede editar
                return false;
            }

            // El tipo de habitación existe, actualiza sus propiedades
            tipoExistente.NombTipo = nombTipo;

            d_tipoHabitacion.GuardarCambios();

            return true;
        }
    }
}
