using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Datos
{
    internal class DTipoHabitacion
    {
        private HotelParanaContext dbHotelParana;

        public DTipoHabitacion()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public bool AgregarTipoHabitacion(TipoHabitacion tipo)
        {
            bool result = true;
            try
            {
                // Intenta insertar el nuevo tipo de habitación en la base de datos
                dbHotelParana.Add(tipo);
                dbHotelParana.SaveChanges();
                return result;
            }
            catch (DbUpdateException ex)
            {
                result = false;
                return result;
            }
        }

        public List<TipoHabitacion> GetTiposHabitacion()
        {
            return dbHotelParana.TipoHabitacions.ToList();
        }

        public TipoHabitacion GetTipoHabitacionByID(int id)
        {
            return dbHotelParana.TipoHabitacions
                                 .FirstOrDefault(t => t.IdTipoHab == id);
        }

        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }
    }
}
