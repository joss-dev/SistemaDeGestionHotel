using SistemaDeGestionHotel.LO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
