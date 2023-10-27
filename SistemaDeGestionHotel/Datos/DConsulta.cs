using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Datos
{
    internal class DConsulta
    {
        private HotelParanaContext dbHotelParana;

        public DConsulta()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public Usuario GetRecepcionistaPorId(int Id)
        {
            return dbHotelParana.Usuarios.FirstOrDefault(u => u.IdUsuario == Id);
        }

        public bool AgregarConsulta(Consultum consulta)
        {
            bool result = true;
            try
            {
                // Intenta insertar el nuevo usuario en la base de datos
                dbHotelParana.Add(consulta);
                dbHotelParana.SaveChanges();
                return result;
            }
            catch (DbUpdateException ex)
            {
                result = false; 
                return result;
            }
        }

        public List<Consultum> ObtenerTodasLasConsultas()
        {
            return dbHotelParana.Consulta.ToList();
        }

        public void MarcarConsultaComoDesactivada(int consultaId)
        {
            var consulta = dbHotelParana.Consulta.FirstOrDefault(c => c.IdConsulta == consultaId); // Busca una consulta activa por ID
            if (consulta != null)
            {
                consulta.Estado = 0; // Cambia el estado a "desactivado"
                dbHotelParana.SaveChanges(); // Guarda los cambios en la base de datos
            }
        }
    }
}
