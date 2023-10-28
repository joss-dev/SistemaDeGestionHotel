using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Datos
{
    internal class DRegistro
    {
        private HotelParanaContext dbHotelParana;

        public DRegistro()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public bool AgregarRegistro(Registro registro)
        {
            bool result = true;
            try
            {
                // Intenta insertar el nuevo registro en la base de datos
                dbHotelParana.Add(registro);
                dbHotelParana.SaveChanges();
                return result;
            }
            catch (DbUpdateException ex)
            {
                result = false;
                return result;
            }
        }

        public List<Registro> GetRegistros()
        {
            return dbHotelParana.Registros.ToList();
        }

        public Registro GetRegistroByID(int id)
        {
            return dbHotelParana.Registros
                                 .FirstOrDefault(r => r.IdRegistro == id);
        }

        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }
    }
}
