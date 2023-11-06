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

        public List<Registro> GetRegistros()
        {
            return dbHotelParana.Registros
                .Include(s => s.IdServicioAdics)
                .ToList();
        }

        public Registro GetRegistroByID(int id)
        {
            return dbHotelParana.Registros
                                 .Include(s => s.IdServicioAdics)
                                 .FirstOrDefault(r => r.IdRegistro == id);
        }

        public Registro GetRegistroByIDHabitacion(int id)
        {
            return dbHotelParana.Registros
                                 .FirstOrDefault(r => r.NroHabitacion == id);
        }

        public Registro ClienteEnEstadiaOReserva(int idCliente)
        {
            return dbHotelParana.Registros
                                 .Include(r => r.IdClienteNavigation)
                                 .Include(h => h.NroHabitacionNavigation)
                                 .FirstOrDefault(r => r.IdCliente == idCliente);
        }

        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }

        public Registro GetRegistroByIDCliente(int id)
        {
            return dbHotelParana.Registros
                                 .Include(s => s.IdServicioAdics)
                                 .FirstOrDefault(r => r.IdCliente == id);
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
            var registro = dbHotelParana.Registros.Include(r => r.IdServicioAdics).FirstOrDefault(r => r.IdRegistro == idRegistro);
            return registro.IdServicioAdics.ToList();
        }
    }
}
