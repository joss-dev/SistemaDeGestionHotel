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

        public bool RealizarRespaldo(string nombreArchivoRespaldo)
        {

            try
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
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool RealizarRestauracion(string nombreArchivoRespaldo)
        {
            try
            {
                string nombreBaseDatos = dbHotelParana.Database.GetDbConnection().Database;

                string comandoSql = $"USE master; ALTER DATABASE {nombreBaseDatos} SET SINGLE_USER WITH ROLLBACK IMMEDIATE; RESTORE DATABASE {nombreBaseDatos} FROM DISK = '{nombreArchivoRespaldo}'";

                using (var command = dbHotelParana.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = comandoSql;
                    dbHotelParana.Database.GetDbConnection().Open();
                    command.ExecuteNonQuery();
                    dbHotelParana.Database.GetDbConnection().Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
