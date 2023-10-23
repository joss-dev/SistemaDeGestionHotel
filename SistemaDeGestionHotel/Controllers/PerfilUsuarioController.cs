using SistemaDeGestionHotel.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionHotel.Controllers
{

    public class PerfilUsuarioController
    {
        DPerfilUsuario d_perfilUsuario = new DPerfilUsuario();

        public List<String> GetTiposPerfil()
        {
            return d_perfilUsuario.GetTiposPerfil();
        }

    }
}
