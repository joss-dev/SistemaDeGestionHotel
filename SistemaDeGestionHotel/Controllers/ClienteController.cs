using SistemaDeGestionHotel.Datos;
using SistemaDeGestionHotel.NEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeGestionHotel.Controllers
{
    public class ClienteController
    {
        DCliente d_cliente = new DCliente();
        public bool AgregarCliente(string apellido, string nombre, string dni, int estado, string telefono)
        {
            Cliente cliente = new Cliente()
            {
                ApellidoCliente = apellido,
                NombreCliente = nombre,
                DniCliente = int.Parse(dni),
                Estado = estado,
                Telefono = telefono
            };

            return d_cliente.AgregarCliente(cliente);
        }

        public List<Cliente> GetClientes()
        {
            return d_cliente.GetClientes();
        }

        public Cliente GetClienteByDNI(int dni)
        {
            return d_cliente.GetClienteByDNI(dni);
        }

        public Cliente GetClienteByID(int id)
        {
            return d_cliente.GetClienteByID(id);
        }

        public bool EditarCliente(int idCliente, string apellido, string nombre, string dni, int estado, string telefono)
        {
            Cliente clienteExistente = d_cliente.GetClienteByID(idCliente);

            if (clienteExistente == null)
            {
                // El cliente no existe, por lo tanto no se puede editar
                return false;
            }

            // El cliente existe, actualiza sus propiedades
            clienteExistente.ApellidoCliente = apellido;
            clienteExistente.NombreCliente = nombre;
            clienteExistente.DniCliente = int.Parse(dni);
            clienteExistente.Estado = estado;
            clienteExistente.Telefono = telefono;

            d_cliente.GuardarCambios();

            return true;
        }

        public bool BajaCliente(int idCliente)
        {
            Cliente clienteExistente = d_cliente.GetClienteByID(idCliente);

            if (clienteExistente == null)
            {
                // El cliente no existe, por lo tanto no se puede editar
                return false;
            }

            clienteExistente.Estado = 0;

            d_cliente.GuardarCambios();

            return true;
        }

    }
}
