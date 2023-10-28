using SistemaDeGestionHotel.Datos;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Controllers
{
    public class PisoController
    {
        DPiso d_piso = new DPiso();

        public bool AgregarPiso(int nroPiso)
        {
            Piso piso = new Piso()
            {
                NroPiso = nroPiso
            };

            return d_piso.AgregarPiso(piso);
        }

        public List<Piso> GetPisos()
        {
            return d_piso.GetPisos();
        }

        public Piso GetPisoByID(int id)
        {
            return d_piso.GetPisoByID(id);
        }

        public bool EditarPiso(int idPiso, int nroPiso)
        {
            Piso pisoExistente = d_piso.GetPisoByID(idPiso);

            if (pisoExistente == null)
            {
                // El piso no existe, por lo tanto no se puede editar
                return false;
            }

            // El piso existe, actualiza sus propiedades
            pisoExistente.NroPiso = nroPiso;

            d_piso.GuardarCambios();

            return true;
        }
    }
}
