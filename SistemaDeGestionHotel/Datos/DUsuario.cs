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

    }
}
