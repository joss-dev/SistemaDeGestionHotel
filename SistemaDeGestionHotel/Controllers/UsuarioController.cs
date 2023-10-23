using SistemaDeGestionHotel.Datos;
using SistemaDeGestionHotel.LO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionHotel.Controllers
{
    public class UsuarioController
    {

        DUsuario d_usuario = new DUsuario();

        public void AgregarUsuario(String nombre, String apellido, string dni, string correoElectronico, string direccion, string nombreUsuario, string password, string rutaFoto, int idPerfil)
        {

            string hashPass = EncriptarPassword.HashPassword(password);


            Usuario user = new Usuario()
            {
                Nombre = nombre,
                Apellido = apellido,
                Dni = int.Parse(dni),
                CorreoElectronico = correoElectronico,
                Direccion = direccion,
                NombreUsuario = nombreUsuario,
                Contraseña = hashPass,
                FotoPerfil = rutaFoto,
                IdPerfilUsuario = idPerfil + 1
            };

            d_usuario.AgregarUsuario(user);
        }


        public List<Usuario> GetUsuarios()
        {
           return d_usuario.GetUsuarios();
        }



    }
}
