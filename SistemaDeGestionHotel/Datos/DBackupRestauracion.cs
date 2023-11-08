using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionHotel.Datos
{
    public class DBackupRestauracion
    {
        private HotelParanaContext dbHotelParana;

        public DBackupRestauracion()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public void RealizarRespaldo(string nombreArchivoRespaldo)
        {
            string nombreBaseDatos = dbHotelParana.Database.GetDbConnection().Database;
            string comandoSql = $"BACKUP DATABASE [{nombreBaseDatos}] TO DISK = '{nombreArchivoRespaldo}'";

            using (var command = dbHotelParana.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = comandoSql;
                dbHotelParana.Database.GetDbConnection().Open();
                command.ExecuteNonQuery();
                dbHotelParana.Database.GetDbConnection().Close();
            }
        }

        public void RealizarRestauracion(string nombreArchivoRespaldo)
        {
            string nombreBaseDatos = dbHotelParana.Database.GetDbConnection().Database;

            string comandoSql = $"USE master; RESTORE DATABASE [{nombreBaseDatos}] FROM DISK = '{nombreArchivoRespaldo}'";

            using (var command = dbHotelParana.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = comandoSql;
                dbHotelParana.Database.GetDbConnection().Open();
                command.ExecuteNonQuery();
                dbHotelParana.Database.GetDbConnection().Close();
            }
        }
    }
}
