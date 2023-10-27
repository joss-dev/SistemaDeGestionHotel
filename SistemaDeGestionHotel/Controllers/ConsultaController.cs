using Microsoft.IdentityModel.Tokens;
using SistemaDeGestionHotel.Datos;
using SistemaDeGestionHotel.NEntidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeGestionHotel.Controllers
{
    public class ConsultaController
    {
        DConsulta dconsulta = new DConsulta();
        DUsuario DUsuario = new DUsuario();

        public void EnviarMensaje(int idConsulta, string nombre, string apellido, string correoElectronico, string motivo, string mensaje)
        {
            //dconsulta.GetRecepcionistaPorId(Id);
            //dconsulta.ObtenerTodasLasConsultas();

            
        }

        //public bool BajaConsulta(int idConsulta)
        //{

            //Consultum consultaExistente = d_usuario.GetUsuarioByID(idUsuario);

            //if (usuarioExistente == null)
            //{
            //    // El usuario no existe, por lo tanto no se puede editar
            //    return false;
            //}


            //usuarioExistente.Estado = 0;

            //d_usuario.GuardarCambios();

            //return true;
        //}
    }


}
