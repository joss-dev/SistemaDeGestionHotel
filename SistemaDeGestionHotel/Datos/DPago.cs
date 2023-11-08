using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel.Datos
{
    internal class DPago
    {
        private HotelParanaContext dbHotelParana;

        public DPago()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public bool AgregarPago(Pago pago)
        {
            bool result = true;
            try
            {
                // Intenta insertar el nuevo pago en la base de datos
                dbHotelParana.Add(pago);
                dbHotelParana.SaveChanges();
                return result;
            }
            catch (DbUpdateException ex)
            {
                result = false;
                return result;
            }
        }

        public Pago GetPagoByIDregistro(int idRegistro)
        {
            return dbHotelParana.Pagos
                                      .Include(p => p.IdMedioPagoNavigation)
                                      .FirstOrDefault(p => p.IdRegistro == idRegistro);
        }

        public List<Pago> GetPagos()
        {
            return dbHotelParana.Pagos.ToList();
        }

        public Pago GetPagoByID(int id)
        {
            return dbHotelParana.Pagos
                                 .Include(p => p.IdMedioPagoNavigation)
                                 .FirstOrDefault(p => p.IdPago == id);
        }

        public List<dynamic> GetPagosByRangoFecha(DateTime nuevaFechaInicio, DateTime nuevaFechaFin)
        {
            var resultados = from pago in dbHotelParana.Pagos
                             join medioPago in dbHotelParana.MediosPagos on pago.IdMedioPago equals medioPago.IdMedioPago
                             where pago.FechaHoraPago >= nuevaFechaInicio && pago.FechaHoraPago <= nuevaFechaFin
                             group pago by medioPago.Nombre into grupo
                             select new
                             {
                                 MedioPago = grupo.Key,
                                 CantidadPagos = grupo.Count()
                             };

            return resultados.ToList();
        }

        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }
    }
}
