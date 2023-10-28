using System;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;
using System.Collections.Generic;

namespace SistemaDeGestionHotel.Datos
{
    internal class DMediosPago
    {
        private HotelParanaContext dbHotelParana;

        public DMediosPago()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public bool AgregarMedioPago(MediosPago medioPago)
        {
            bool result = true;
            try
            {
                // Intenta insertar el nuevo medio de pagos en la base de datos
                dbHotelParana.Add(medioPago);
                dbHotelParana.SaveChanges();
                return result;
            }
            catch (DbUpdateException ex)
            {
                result = false;
                return result;
            }
        }
        public MediosPago ObtenerMedioPagoPorID(int idMedioPago)
        {
            return dbHotelParana.MediosPagos.FirstOrDefault(c => c.IdMedioPago == idMedioPago); // Busca una consulta activa por ID
        }

        public List<MediosPago> ObtenerTodosLosMediosDePago()
        {
            return dbHotelParana.MediosPagos.ToList();
        }
    }
}
