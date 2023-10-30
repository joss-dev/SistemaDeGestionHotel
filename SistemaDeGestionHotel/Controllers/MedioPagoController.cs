using Microsoft.IdentityModel.Tokens;
using SistemaDeGestionHotel.Datos;
using SistemaDeGestionHotel.NEntidades;
using SistemaDeGestionHotel.views.admin;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeGestionHotel.Controllers
{
    public class MedioPagoController
    {
        DMediosPago dMediosPago = new DMediosPago();

        public bool RegistrarMedioPago(string nombre, int idTipoMP, int estado)
        {
            MediosPago medio_pago = new MediosPago()
            {
                Nombre = nombre,
                Estado = estado,
                IdTipoMedioPago = idTipoMP
            };

            return dMediosPago.AgregarMedioPago(medio_pago);
        }

        public List<MediosPago> ObtenerMedioPago()
        {
            return dMediosPago.ObtenerTodosLosMediosPago();
        }

        public MediosPago TraerMPPorID(int id)
        {
            return dMediosPago.ObtenerMedioPagoPorID(id);
        }

        /*public bool DesactivarMP(int idMP)
        {
            return dMediosPago.MarcarMPDesactivado(idMP);
        }*/

        public List<TipoMedioPago> ObtenerTiposMP()
        {
            return dMediosPago.ObtenerTiposMedioPago();
        }

        public bool EditarMedioPago(int idMP, string nombre, int idTipoMP, int Estado)
        {
            MediosPago MPExistente = dMediosPago.ObtenerMedioPagoPorID(idMP);

            if (MPExistente == null)
            {
                // El usuario no existe, por lo tanto no se puede editar
                return false;
            }

            else
            {
                MPExistente.Nombre = nombre;
                MPExistente.IdTipoMedioPago = idTipoMP;
                MPExistente.Estado = Estado;            
            }

            dMediosPago.GuardarCambios();

            return true;
        }
    }
}
