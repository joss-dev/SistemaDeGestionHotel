using Microsoft.VisualBasic;
using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.Datos;
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
    public partial class RegistrarCliente : Form
    {

        ClienteController cliente_controller = new ClienteController();
        HabitacionController habitacion_controller = new HabitacionController();
        private int idHabitacion;
        private Usuario usuarioInicioSesion;
        private int dniCliente;
        public RegistrarCliente(Usuario usuario, int idHab, int dni)
        {
            InitializeComponent();
            idHabitacion = idHab;
            usuarioInicioSesion = usuario;
            dniCliente = dni;
        }

        private void ValidacionApellido(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(TApellido, errorProvider1);
        }

        private void ValidacionNombre(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(TNombre, errorProvider1);
        }

        private void ValidacionDni(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(TDni, errorProvider1);
        }

        private void ValidacionTelefono(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(textBoxTelefono, errorProvider1);
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidacionTextBox.ValidarNoVacio(textBoxTelefono, TDni, TApellido, TNombre))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Verifica que la longitud de la entrada esté entre 7 y 8.
                if (TDni.Text.Length < 7 || TDni.Text.Length > 8)
                {
                    MessageBox.Show("El DNI debe tener entre 7 y 8 números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cliente_controller.AgregarCliente(TApellido.Text, TNombre.Text, TDni.Text, 1, textBoxTelefono.Text))
                    {
                        MessageBox.Show("Cliente registrado exitosamente!");

                        Cliente clienteBuscado = cliente_controller.GetClienteByDNI(int.Parse(TDni.Text));

                        Habitacion habitacion = habitacion_controller.GetHabitacionByID(idHabitacion);

                        Form agregarHues = new AgregarHuesped(usuarioInicioSesion, clienteBuscado, habitacion, int.Parse(TDni.Text));

                        agregarHues.StartPosition = FormStartPosition.CenterScreen;

                        DialogResult result = agregarHues.ShowDialog();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el cliente!");
                    }
                }
            }
        }

        private void CargarDatos(object sender, EventArgs e)
        {
            TDni.Text = dniCliente.ToString();
        }
    }
}
