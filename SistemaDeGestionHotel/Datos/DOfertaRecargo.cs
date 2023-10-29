using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }
    }
}
