using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Datos
{
    internal class DPerfilUsuario
    {
        private HotelParanaContext dbHotelParana;

        public DPerfilUsuario()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public List<String> GetTiposPerfil()
        {
            return dbHotelParana.PerfilUsuarios
                                 .Select(perfil => perfil.Nombre)
                                 .ToList();
        }
    }
}
