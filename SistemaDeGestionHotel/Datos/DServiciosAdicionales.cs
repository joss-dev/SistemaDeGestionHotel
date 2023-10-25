using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Datos
{
    internal class DServiciosAdicionales
    {
        private HotelParanaContext dbHotelParana;

        public DServiciosAdicionales()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public void GuardarServicios(List<string> servicios)
        {
            // Aquí es donde guardarías los servicios en la base de datos
        }

    }
}
