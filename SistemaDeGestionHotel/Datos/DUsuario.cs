using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;


namespace SistemaDeGestionHotel.Datos
{
    internal class DUsuario
    {
        private HotelParanaContext dbHotelParana;

        public DUsuario()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public bool AgregarUsuario(Usuario usuario)
        {
            bool result = true;
            try
            {
                // Intenta insertar el nuevo usuario en la base de datos
                dbHotelParana.Add(usuario);
                dbHotelParana.SaveChanges();
                return result;
            }
            catch (DbUpdateException ex)
            {
                result = false;
                return result;
            }
        }

        public List<Usuario> GetUsuarios()
        {
            return dbHotelParana.Usuarios.ToList();
        }

        public Usuario GetUsuarioByNombreUsuario(string nombreUsuario)
        {
            return dbHotelParana.Usuarios
                                .FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
        }

        public Usuario GetUsuarioByID(int id)
        {
            return dbHotelParana.Usuarios
                                .FirstOrDefault(u => u.IdUsuario == id);
        }

        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }
    }
}
