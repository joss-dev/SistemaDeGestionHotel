using Microsoft.EntityFrameworkCore;
using SistemaDeGestionHotel.NEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionHotel.Datos
{
    internal class DCliente
    {
        private HotelParanaContext dbHotelParana;

        public DCliente()
        {
            dbHotelParana = new HotelParanaContext();
        }

        public bool AgregarCliente(Cliente cliente)
        {
            bool result = true;
            try
            {
                // Intenta insertar el nuevo cliente en la base de datos
                dbHotelParana.Add(cliente);
                dbHotelParana.SaveChanges();
                return result;
            }
            catch (DbUpdateException ex)
            {
                result = false;
                return result;
            }
        }

        public List<Cliente> GetClientes()
        {
            return dbHotelParana.Clientes.ToList();
        }

        public Cliente GetClienteByDNI(int dni)
        {
            return dbHotelParana.Clientes
                                .FirstOrDefault(c => c.DniCliente == dni);
        }

        public Cliente GetClienteByID(int id)
        {
            return dbHotelParana.Clientes
                                .FirstOrDefault(c => c.IdCliente == id);
        }

        public void GuardarCambios()
        {
            dbHotelParana.SaveChanges();
        }
    }
}
