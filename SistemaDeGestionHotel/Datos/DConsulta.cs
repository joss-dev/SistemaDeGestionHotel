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

        public Consultum ObtenerConsultaPorID(int idConsulta)
        {
            return dbHotelParana.Consulta.FirstOrDefault(c => c.IdConsulta == idConsulta); // Busca una consulta activa por ID
        }

        public List<Consultum> ObtenerTodasLasConsultas()
        {
            return dbHotelParana.Consulta.ToList();
        }

        public bool MarcarConsultaComoResuelta(int consultaId)
        {
            bool result = true;

            Consultum consulta = ObtenerConsultaPorID(consultaId);
            if (consulta != null)
            {
                consulta.Estado = 0; // Cambia el estado a "desactivado"
                dbHotelParana.SaveChanges(); // Guarda los cambios en la base de datos
                return result;
            }
            else
            {
                result = false;
                return result;
            }
        }

        public List<Consultum> ObtenerConsultasConUsuarios()
        {
            // Recupera las consultas con los datos de usuario relacionados
            var consultas = dbHotelParana.Consulta
                .Include(c => c.IdUsuarioNavigation) // Carga la entidad Usuario relacionada
                .ToList();

            return consultas;
        }
    }
}
