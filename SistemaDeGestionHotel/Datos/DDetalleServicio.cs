using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Datos
{
    internal class DDetalleServicio
    {
        private HotelParanaContext dbHotelParana;

        public DDetalleServicio()
        {
            dbHotelParana = new HotelParanaContext();
        }




        //falto el pk enn esta tabla
        //public DetalleServicio GetDetalleServicioByID(int id)
        //{
        //    return dbHotelParana.DetalleServicios
        //                         .FirstOrDefault(d => d.Id == id);
        //}

        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }
    }
}
