using Microsoft.VisualBasic;
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
    public partial class AgregarHuesped : Form
    {

        private Habitacion habitacionAgregar;
        private Cliente clienteAgregar;
        private int dniCliente;
        private Usuario usuarioInicioSesion;


        HabitacionController habitacion_controller = new HabitacionController();
        RegistroController registro_controller = new RegistroController();

        public AgregarHuesped(Usuario usuario, Cliente cliente, Habitacion habitacion, int dni)
        {
            InitializeComponent();
            comboBoxEstado.SelectedIndex = 0;
            clienteAgregar = cliente;
            habitacionAgregar = habitacion;
            dniCliente = dni;
            usuarioInicioSesion = usuario;
        }

        private void CambiarEstadoDeHabitacion(int habitacionId, int nuevoEstado)
        {
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidacionTextBox.ValidarNoVacio(TCantidadHuespedes))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool result = registro_controller.AgregarRegistro(int.Parse(TCantidadHuespedes.Text), habitacionAgregar.Precio, comboBoxEstado.SelectedIndex, dateTimeIngreso.Value, dateTimeSalida.Value, usuarioInicioSesion.IdUsuario, habitacionAgregar.IdHabitacion, clienteAgregar.IdCliente);
                
                if(comboBoxEstado.SelectedIndex == 0)
                {
                    habitacion_controller.MarcarReservadaHabitacion(habitacionAgregar.IdHabitacion);

                }else
                {
                    habitacion_controller.MarcarOcupadaHabitacion(habitacionAgregar.IdHabitacion);
                }

                if (result)
                {
                    string mensaje = $"Cantidad de Huéspedes: {TCantidadHuespedes.Text}\n" +
                                     $"Precio: {habitacionAgregar.Precio}\n" +
                                     $"Estado: {comboBoxEstado.SelectedItem.ToString()}\n" +
                                     $"Fecha de Ingreso: {dateTimeIngreso.Value.ToString()}\n" +
                                     $"Fecha de Salida: {dateTimeSalida.Value.ToString()}\n" +
                                     $"Teléfono: {textBoxTelefono.Text}\n" +
                                     $"DNI: {TDni.Text}\n" +
                                     $"Apellido: {TApellido.Text}\n" +
                                     $"Nombre: {TNombre.Text}";

                    MessageBox.Show(mensaje, "Se registro con exito, detalles del registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al cargar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            MsgBoxResult result = (MsgBoxResult)MessageBox.Show("¿Está seguro de que desea cerrar el formulario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == MsgBoxResult.Yes)
            {
                this.DialogResult = DialogResult.OK;

                // Cerrar el formulario secundario
                this.Close();
            }
        }


        private void ValidacionCantHuesped(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(TCantidadHuespedes, errorProviderNumero);
        }

        private void estado_selectedIndex(object sender, EventArgs e)
        {
            int indiceSeleccionado = comboBoxEstado.SelectedIndex;

            if (indiceSeleccionado == 0)
            {
                dateTimeIngreso.Enabled = true;
                // Establecer la fecha mínima de reserva como mañana
                dateTimeIngreso.MinDate = DateTime.Today.AddDays(1);

                // Establecer la fecha de salida como mínimo un día después de la fecha de ingreso
                dateTimeSalida.MinDate = dateTimeIngreso.Value.AddDays(1);

            }
            else if (indiceSeleccionado == 1)
            {
                // Establecer la fecha mínima como la fecha de hoy
                dateTimeIngreso.MinDate = DateTime.Today;

                dateTimeIngreso.Value = DateTime.Today;


                // Deshabilitar el control para que el usuario no pueda cambiar la fecha
                dateTimeIngreso.Enabled = false;

                // Establecer la fecha de salida como mínimo un día después de la fecha de ingreso
                dateTimeSalida.MinDate = DateTime.Today.AddDays(1);

            }
        }

        private void btnServiciosAd_Click(object sender, EventArgs e)
        {
            Form registrarServ = new registrarServicio();

            registrarServ.StartPosition = FormStartPosition.CenterScreen;

            DialogResult result = registrarServ.ShowDialog();

            // Verificar si se cerró el formulario secundario
            if (result == DialogResult.OK)
            {
                // Realizar acciones después de cerrar el formulario secundario si es necesario
            }
        }

        private void CargarDatos(object sender, EventArgs e)
        {

            TDni.Text = clienteAgregar.DniCliente.ToString();
            TApellido.Text = clienteAgregar.ApellidoCliente.ToString(); 
            TNombre.Text = clienteAgregar.NombreCliente.ToString();
            textBoxTelefono.Text = clienteAgregar.Telefono.ToString();

            //carga datos de la habitacion
            labelNroHabitacion.Text = habitacionAgregar.NroHabitacion.ToString();
            labelCantCamas.Text = habitacionAgregar.CantidadCamas.ToString();
            labelEstado.Text = habitacionAgregar.IdEstadoNavigation.NombEstado.ToString();
            labelPrecio.Text = habitacionAgregar.Precio.ToString("N2");
            labelNroPiso.Text = habitacionAgregar.IdPisoNavigation.NroPiso.ToString();
            labelTipoHabitacion.Text = habitacionAgregar.IdTipoHabNavigation.NombTipo.ToString();
        }
    }

}
