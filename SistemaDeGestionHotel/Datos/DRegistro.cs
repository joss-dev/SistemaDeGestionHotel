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

        public void ReloadAllEntities()
        {
            var changedEntries = dbHotelParana.ChangeTracker.Entries()
                .Where(e => e.State != EntityState.Unchanged)
                .ToList();

            foreach (var entry in changedEntries)
            {
                entry.Reload();
            }
        }

        public List<Registro> GetRegistros()
        {
            this.ReloadAllEntities();
            return dbHotelParana.Registros
                .Include(s => s.IdServicioAdics)
                .ToList();
        }

        public Registro GetRegistroByID(int id)
        {
            this.ReloadAllEntities();
            return dbHotelParana.Registros
                                 .Include(s => s.IdServicioAdics)
                                 .FirstOrDefault(r => r.IdRegistro == id);
        }

        public Registro GetRegistroFacturadoByIDHabitacion(int id)
        {
            var registro = dbHotelParana.Registros
                                .Where(r => r.EstadoOcupacion == 2)
                                .Include(s => s.IdServicioAdics)
                                .FirstOrDefault(r => r.IdCliente == id);

            // Recargar el objeto desde la base de datos
            dbHotelParana.Entry(registro).Reload();

            return registro;
        }


        public Registro GetRegistroByIDHabitacion(int id)
        {
            this.ReloadAllEntities();
            var registro = dbHotelParana.Registros
                                 .Where(r => r.EstadoOcupacion == 1 || r.EstadoOcupacion == 0)
                                 .FirstOrDefault(r => r.NroHabitacion == id);
            if (registro == null)
            {
                return registro;
            }
            else
            {
                // Recargar el objeto desde la base de datos
                dbHotelParana.Entry(registro).Reload();
                return registro;
            }
        }

        public Registro ClienteEnEstadiaOReserva(int idCliente)
        {
            this.ReloadAllEntities();
            return dbHotelParana.Registros
                                 .Include(r => r.IdClienteNavigation)
                                 .Include(h => h.NroHabitacionNavigation)
                                 .FirstOrDefault(r => r.IdCliente == idCliente);
        }

        public void GuardarCambios()
        {
            this.ReloadAllEntities();
            dbHotelParana.SaveChanges();
        }

        public Registro GetRegistroByIDCliente(int id)
        {
            var registro = dbHotelParana.Registros
                                .Where(r => r.EstadoOcupacion == 1 || r.EstadoOcupacion == 0)
                                .Include(s => s.IdServicioAdics)
                                .FirstOrDefault(r => r.IdCliente == id);
            if(registro == null)
            {
                return registro;
            }else
            {
                // Recargar el objeto desde la base de datos
                dbHotelParana.Entry(registro).Reload();
                return registro;
            }
        }

        public bool AgregarServicioAdicional(ServiciosAdicionale servicioAdicional, Registro registro)
        {
            bool result = true;
            try
            {
                dbHotelParana.Entry(registro).Collection(r => r.IdServicioAdics).Load();

                if (registro.IdServicioAdics.Any(sa => sa.IdServicioAdic == servicioAdicional.IdServicioAdic))
                {
                    return false;
                }
                registro.IdServicioAdics.Add(servicioAdicional);
                dbHotelParana.SaveChanges();
                return result;
                  
            }
            catch (DbUpdateException ex)
            {
                result = false;
                return result;
            }
        }

        public List<ServiciosAdicionale> GetServiciosAdicionales(int idRegistro)
        {
            this.ReloadAllEntities();
            var registro = dbHotelParana.Registros.Include(r => r.IdServicioAdics).FirstOrDefault(r => r.IdRegistro == idRegistro);
            return registro.IdServicioAdics.ToList();
        }

        public void ActualizarDatos(Registro registro)
        {
            dbHotelParana.Update(registro);
            dbHotelParana.Entry(registro).State = EntityState.Modified;
            dbHotelParana.SaveChanges();
        }
    }
}
