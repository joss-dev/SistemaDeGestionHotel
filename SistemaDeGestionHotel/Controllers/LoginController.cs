using SistemaDeGestionHotel.Datos;
using SistemaDeGestionHotel.NEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionHotel.Controllers
{
    public class LoginController
    {
        DUsuario d_usuario = new DUsuario();

        public Usuario? IniciarSesion(string nombreUsuario, string pass)
        {
            Usuario usuario = d_usuario.GetUsuarioByNombreUsuario(nombreUsuario);

            if (usuario != null)
            {
                bool passCorrecta = EncriptarPassword.VerifyPassword(pass, usuario.Contraseña);

                if (passCorrecta && usuario.Estado == 1)
                {
                    // La contraseña es correcta, el usuario ha iniciado sesion.
                    return usuario;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                // El usuario no fue encontrado en la base de datos.
                return null;
            }
        }

    }
}
