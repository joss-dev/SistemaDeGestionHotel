using SistemaDeGestionHotel.Datos;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Controllers
{
    public class ServiciosAdicionalesController
    {
        DServiciosAdicionales d_serviciosAdicionales = new DServiciosAdicionales();

        public bool AgregarServicioAdicional(string nombServicio, double precio, int estado)
        {
            ServiciosAdicionale servicioAdicional = new ServiciosAdicionale()
            {
                NombServicio = nombServicio,
                Precio = precio,
                Estado = estado
            };

            return d_serviciosAdicionales.AgregarServicioAdicional(servicioAdicional);
        }

        public List<ServiciosAdicionale> GetServiciosAdicionales()
        {
            return d_serviciosAdicionales.GetServiciosAdicionales();
        }

        public ServiciosAdicionale GetServicioAdicionalByID(int id)
        {
            return d_serviciosAdicionales.GetServicioAdicionalByID(id);
        }

        public bool EditarServicioAdicional(int idServicio, string nombServicio, double precio, int estado)
        {
            ServiciosAdicionale servicioExistente = d_serviciosAdicionales.GetServicioAdicionalByID(idServicio);

            if (servicioExistente == null)
            {
                // El servicio adicional no existe, por lo tanto no se puede editar
                return false;
            }

            // El servicio adicional existe, actualiza sus propiedades
            servicioExistente.NombServicio = nombServicio;
            servicioExistente.Precio = precio;
            servicioExistente.Estado = estado;

            d_serviciosAdicionales.GuardarCambios();

            return true;
        }

        public bool BajaServicioAdicional(int idServicio)
        {
            ServiciosAdicionale servicioExistente = d_serviciosAdicionales.GetServicioAdicionalByID(idServicio);

            if (servicioExistente == null)
            {
                // El servicio adicional no existe, por lo tanto no se puede editar
                return false;
            }

            servicioExistente.Estado = 0;

            d_serviciosAdicionales.GuardarCambios();

            return true;
        }
    }
}
