using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Datos
{
    internal class DOfertaRecargo
    {
        private HotelParanaContext dbHotelParana;

        public DOfertaRecargo()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public bool CargarOfertaRecargo(OfertasRecargo oferta_recargo)
        {

            try
            {
                // Intenta insertar el nuevo medio de pagos en la base de datos
                dbHotelParana.Add(oferta_recargo);
                dbHotelParana.SaveChanges();
                return true;
            }
            catch (DbUpdateException ex)
            {
                // Considera registrar el error en algún lugar para poder depurarlo
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public OfertasRecargo ObtenerOfertaRecargoPorID(int idOfertaRecargo)
        {
            return dbHotelParana.OfertasRecargos.FirstOrDefault(c => c.IdOfertaRecargo == idOfertaRecargo); // Busca una consulta activa por ID
        }

        public List<OfertasRecargo> ObtenerTodasLasOfertasRecargos()
        {
            return dbHotelParana.OfertasRecargos.ToList();
        }

        public List<String> ObtenerNombresOfRecargos()
        {
            return dbHotelParana.OfertasRecargos
                                 .Select(s => s.NombOfertaRecargo)
                                 .ToList();
        }

        public List<String> ObtenerNombresOferta()
        {
            return dbHotelParana.OfertasRecargos
                                 .Where(p => p.PorcentajeRecargo == 0)
                                 .Where(p => p.Estado == 1)
                                 .Select(s => s.NombOfertaRecargo)
                                 .ToList();
        }

        public List<OfertasRecargo> ObtenerOfertas()
        {
            return dbHotelParana.OfertasRecargos
                                 .Where(p => p.PorcentajeRecargo == 0)
                                 .Where(p => p.Estado == 1)
                                 .ToList();
        }

        public List<OfertasRecargo> ObtenerRecargos()
        {
            return dbHotelParana.OfertasRecargos
                                 .Where(p => p.PorcentajeDescuento == 0)
                                 .Where(p => p.Estado == 1)
                                 .ToList();
        }

        public List<String> ObtenerNombresRecargo()
        {
            return dbHotelParana.OfertasRecargos
                                 .Where(p => p.PorcentajeDescuento == 0)
                                 .Where(p => p.Estado == 1)
                                 .Select(s => s.NombOfertaRecargo)
                                 .ToList();
        }

        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }

        public void DarBajaOfertasYRecargos()
        {
            DateTime fechaActual = DateTime.Now;

            var darbaja = dbHotelParana.OfertasRecargos
                          .Where(p => p.FechaHasta < fechaActual);

            if (darbaja == null)
            {
                return;
            }
            else
            {
                foreach (OfertasRecargo baja in darbaja)
                {
                    baja.Estado = 0;
                }
            }

            dbHotelParana.SaveChanges();
        }
    }
}
