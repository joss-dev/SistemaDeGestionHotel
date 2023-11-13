using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Datos
{
    internal class DPiso
    {
        private HotelParanaContext dbHotelParana;

        public DPiso()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public bool AgregarPiso(Piso piso)
        {
            bool result = true;
            try
            {
                // Intenta insertar el nuevo piso en la base de datos
                dbHotelParana.Add(piso);
                dbHotelParana.SaveChanges();
                return result;
            }
            catch (DbUpdateException ex)
            {
                result = false;
                return result;
            }
        }

        public List<Piso> GetPisos()
        {
            return dbHotelParana.Pisos.ToList();
        }

        public Piso GetPisoByID(int id)
        {
            return dbHotelParana.Pisos
                                 .FirstOrDefault(p => p.IdPiso == id);
        }

        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }
    }
}
