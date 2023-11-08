using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionHotel.views.recep
{
    public partial class InfoRegistro : Form
    {
        private Habitacion habitacionInfo;
        private int idHabitacion;
        HabitacionController habitacion_controller = new HabitacionController();
        RegistroController registro_controller = new RegistroController();
        ClienteController ClienteController = new ClienteController();

        public InfoRegistro(int idhab)
        {
            InitializeComponent();
            idHabitacion = idhab;
        }

        private void CargarDatos(object sender, EventArgs e)
        {
            habitacionInfo = habitacion_controller.GetHabitacionByID(idHabitacion);
            Registro registroInfo = registro_controller.GetRegistroByIDHabitacion(idHabitacion);
            Cliente clienteInfo = ClienteController.GetClienteByID(registroInfo.IdCliente);

            if(registroInfo.EstadoOcupacion != 2)
            {
                labelApellido.Text = clienteInfo.ApellidoCliente.ToString();
                labelNombre.Text = clienteInfo.NombreCliente.ToString();
                labelTelefono.Text = clienteInfo.Telefono.ToString();
                labelDni.Text = clienteInfo.DniCliente.ToString();


                labelFechaIngreso.Text = registroInfo.FechaIngreso.ToShortDateString();
                labelFechaSalida.Text = registroInfo.FechaSalida.ToShortDateString();
                labelCantidaHuespedes.Text = registroInfo.CantidadHuespedes.ToString();


                //carga datos de la habitacion
                labelNroHabitacion.Text = habitacionInfo.NroHabitacion.ToString();
                labelCantidadCamas.Text = habitacionInfo.CantidadCamas.ToString();
                labelPrecio.Text = habitacionInfo.Precio.ToString("N2");
                labelNroPiso.Text = habitacionInfo.IdPisoNavigation.NroPiso.ToString();
                labelTipo.Text = habitacionInfo.IdTipoHabNavigation.NombTipo.ToString();
            }
        }
    }
}
