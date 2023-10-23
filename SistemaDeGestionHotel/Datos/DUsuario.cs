using Microsoft.VisualBasic.ApplicationServices;
using SistemaDeGestionHotel.LO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
