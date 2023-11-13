using Microsoft.IdentityModel.Tokens;
using SistemaDeGestionHotel.Datos;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Controllers
{
    public class UsuarioController
    {

        DUsuario d_usuario = new DUsuario();

        public bool AgregarUsuario(String nombre, String apellido, string dni, string correoElectronico, string direccion, string nombreUsuario, string password, string rutaFoto, int idPerfil)
        {

            string hashPass = EncriptarPassword.HashPassword(password);


            Usuario user = new Usuario()
            {
                Nombre = nombre,
                Apellido = apellido,
                Dni = int.Parse(dni),
                CorreoElectronico = correoElectronico,
                Estado = 1,
                Direccion = direccion,
                NombreUsuario = nombreUsuario,
                Contraseña = hashPass,
                FotoPerfil = rutaFoto,
                IdPerfilUsuario = idPerfil + 1
            };

            return d_usuario.AgregarUsuario(user);
        }


        public List<Usuario> GetUsuarios()
        {
            return d_usuario.GetUsuarios();
        }

        public Usuario GetUsuarioByNombreUsuario(string nombreUsuario)
        {
            return d_usuario.GetUsuarioByNombreUsuario(nombreUsuario);
        }

        public Usuario GetUsuarioByID(int id)
        {
            return d_usuario.GetUsuarioByID(id);
        }

        public bool EditarUsuario(int idUsuario, string nombre, string apellido, string dni, string correoElectronico, string direccion, string nombreUsuario, string password, string rutaFoto, int idPerfil)
        {
            Usuario usuarioExistente = d_usuario.GetUsuarioByID(idUsuario);

            if (usuarioExistente == null)
            {
                // El usuario no existe, por lo tanto no se puede editar
                return false;
            }

            if (password.IsNullOrEmpty())
            {
                // El usuario existe, actualiza sus propiedades
                usuarioExistente.Nombre = nombre;
                usuarioExistente.Apellido = apellido;
                usuarioExistente.Dni = int.Parse(dni);
                usuarioExistente.CorreoElectronico = correoElectronico;
                usuarioExistente.Direccion = direccion;
                usuarioExistente.NombreUsuario = nombreUsuario;
                usuarioExistente.FotoPerfil = rutaFoto;
                usuarioExistente.IdPerfilUsuario = idPerfil + 1;
            }
            else
            {
                string hash = EncriptarPassword.HashPassword(password);

                // El usuario existe, actualiza sus propiedades
                usuarioExistente.Nombre = nombre;
                usuarioExistente.Apellido = apellido;
                usuarioExistente.Dni = int.Parse(dni);
                usuarioExistente.CorreoElectronico = correoElectronico;
                usuarioExistente.Direccion = direccion;
                usuarioExistente.Contraseña = hash;
                usuarioExistente.NombreUsuario = nombreUsuario;
                usuarioExistente.FotoPerfil = rutaFoto;
                usuarioExistente.IdPerfilUsuario = idPerfil + 1;
            }



            d_usuario.GuardarCambios();

            return true;
        }

        public bool BajaUsuario(int idUsuario)
        {

            Usuario usuarioExistente = d_usuario.GetUsuarioByID(idUsuario);

            if (usuarioExistente == null)
            {
                // El usuario no existe, por lo tanto no se puede editar
                return false;
            }


            usuarioExistente.Estado = 0;

            d_usuario.GuardarCambios();

            return true;
        }

        public bool AltaUsuario(int idUsuario)
        {

            Usuario usuarioExistente = d_usuario.GetUsuarioByID(idUsuario);

            if (usuarioExistente == null)
            {
                // El usuario no existe, por lo tanto no se puede editar
                return false;
            }


            usuarioExistente.Estado = 1;

            d_usuario.GuardarCambios();

            return true;
        }
    }
}
