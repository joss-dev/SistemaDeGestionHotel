using SistemaDeGestionHotel.Datos;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Controllers
{
    public class RegistroController
    {
        DRegistro d_registro = new DRegistro();
        HabitacionController habitacionController = new HabitacionController();

        public bool AgregarRegistro(int cantidadHuespedes, double precioHabPactado, int estadoOcupacion, DateTime fechaIngreso, DateTime fechaSalida, int idUsuario, int nroHabitacion, int idCliente)
        {
            
            Registro registro = new Registro()
            {
                CantidadHuespedes = cantidadHuespedes,
                PrecioHabPactado = precioHabPactado,
                EstadoOcupacion = estadoOcupacion,
                FechaIngreso = fechaIngreso,
                FechaSalida = fechaSalida,
                IdUsuario = idUsuario,
                NroHabitacion = nroHabitacion,
                IdCliente = idCliente
            };

            return d_registro.AgregarRegistro(registro);
        }

        public List<Registro> GetRegistros()
        {
            return d_registro.GetRegistros();
        }

        public Registro GetRegistroByID(int id)
        {
            return d_registro.GetRegistroByID(id);
        }

        public bool EditarRegistro(int idRegistro, int cantidadHuespedes, double precioHabPactado, int estadoOcupacion, DateTime fechaIngreso, DateTime fechaSalida, int idUsuario, int nroHabitacion, int idCliente)
        {
            Registro registroExistente = d_registro.GetRegistroByID(idRegistro);

            if (registroExistente == null)
            {
                // El registro no existe, por lo tanto no se puede editar
                return false;
            }

            // El registro existe, actualiza sus propiedades
            registroExistente.CantidadHuespedes = cantidadHuespedes;
            registroExistente.PrecioHabPactado = precioHabPactado;
            registroExistente.EstadoOcupacion = estadoOcupacion;
            registroExistente.FechaIngreso = fechaIngreso;
            registroExistente.FechaSalida = fechaSalida;
            registroExistente.IdUsuario = idUsuario;
            registroExistente.NroHabitacion = nroHabitacion;
            registroExistente.IdCliente = idCliente;

            d_registro.GuardarCambios();

            return true;
        }
    }
}
