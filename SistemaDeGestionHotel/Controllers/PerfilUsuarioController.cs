using SistemaDeGestionHotel.Datos;

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
