using Microsoft.IdentityModel.Tokens;
using SistemaDeGestionHotel.Datos;
using SistemaDeGestionHotel.NEntidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeGestionHotel.Controllers
{
    public class ConsultaController
    {
        DConsulta dconsulta = new DConsulta();

        public bool EnviarMensaje(int idUsuario, string motivo, string mensaje)
        {
            Consultum consulta = new Consultum()
            {
                IdUsuario = idUsuario,
                Asunto = motivo,
                Mensaje = mensaje
            };

            return dconsulta.AgregarConsulta(consulta);
        }

        public List<Consultum> ObtenerConsultas()
        {
            return dconsulta.ObtenerTodasLasConsultas();
        }

        public bool ConsultaResuelta(int idConsulta)
        {
            return dconsulta.MarcarConsultaComoResuelta(idConsulta);
        }

        public List<Consultum> ObtenerConsultasConUsuarios()
        {
               return dconsulta.ObtenerConsultasConUsuarios();
        }

    }


}
