using SistemaDeGestionHotel.Datos;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Controllers
{
    internal class OfertaRecargoControllers
    {
        DOfertaRecargo d_ofertaRecargo = new DOfertaRecargo();

        public bool CargarOfertaRecargo(string nombre, DateTime fecha_desde, DateTime fecha_hasta, int estado, float porcentajeDesc, float porcentajeRecargo)
        {
            OfertasRecargo oferta_recargo = new OfertasRecargo()
            {
                NombOfertaRecargo = nombre,
                FechaDesde = fecha_desde,
                Estado = estado,
                FechaHasta = fecha_hasta,
                PorcentajeDescuento = porcentajeDesc,
                PorcentajeRecargo = porcentajeRecargo
            };

            return d_ofertaRecargo.CargarOfertaRecargo(oferta_recargo);
        }

        public List<OfertasRecargo> ObtenerOfertaRecargo()
        {
            return d_ofertaRecargo.ObtenerTodasLasOfertasRecargos();
        }

        public OfertasRecargo TraerORPorID(int id)
        {
            return d_ofertaRecargo.ObtenerOfertaRecargoPorID(id);
        }

        public bool EditarOfertaRecargo(int IdOfertaRecargo, string nombre, DateTime fecha_desde, DateTime fecha_hasta, int estado, float porcentajeDesc, float porcentajeRecargo)
        {
            OfertasRecargo ORExistente = d_ofertaRecargo.ObtenerOfertaRecargoPorID(IdOfertaRecargo);

            if (ORExistente == null)
            {
                // El usuario no existe, por lo tanto no se puede editar
                return false;
            }
            else
            {
                ORExistente.NombOfertaRecargo = nombre;
                ORExistente.FechaDesde = fecha_desde;
                ORExistente.FechaHasta = fecha_hasta;
                ORExistente.Estado = estado;
                ORExistente.PorcentajeDescuento = porcentajeDesc;
                ORExistente.PorcentajeRecargo = porcentajeRecargo;
            }

            d_ofertaRecargo.GuardarCambios();

            return true;
        }

        public void DarBajaOfertasYRecargos()
        {
            d_ofertaRecargo.DarBajaOfertasYRecargos();
        }

        public List<String> ObtenerNombOfertasRecargo()
        {
            return d_ofertaRecargo.ObtenerNombresOfRecargos();
        }

        public List<String> ObtenerNombresRecargo()
        {
            return d_ofertaRecargo.ObtenerNombresRecargo();
        }

        public List<String> ObtenerNombresOferta()
        {
            return d_ofertaRecargo.ObtenerNombresOferta();
        }

        public List<OfertasRecargo> ObtenerOfertas()
        {
            return d_ofertaRecargo.ObtenerOfertas();
        }

        public List<OfertasRecargo> ObtenerRecargos()
        {
            return d_ofertaRecargo.ObtenerRecargos();
        }
    }
}
