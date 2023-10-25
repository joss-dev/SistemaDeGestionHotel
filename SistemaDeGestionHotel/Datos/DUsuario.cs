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

        public void AgregarUsuario(Usuario usuario)
        {
            dbHotelParana.Add(usuario);
            dbHotelParana.SaveChanges();
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
