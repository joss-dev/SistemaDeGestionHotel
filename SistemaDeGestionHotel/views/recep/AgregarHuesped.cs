using Microsoft.VisualBasic;
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
        public AgregarHuesped()
        {
            InitializeComponent();
            comboBoxEstado.SelectedIndex = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidacionTextBox.ValidarNoVacio(TDni, TNombre, TApellido, TCantidadHuespedes, textBoxTelefono))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Registrado!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ValidacionNombre(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(TNombre, errorProviderNumero);
        }

        private void ValidacionApellido(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(TApellido, errorProviderNumero);
        }

        private void ValidacionDni(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(TDni, errorProviderNumero);
        }

        private void ValidacionCantHuesped(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(TCantidadHuespedes, errorProviderNumero);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void estado_selectedIndex(object sender, EventArgs e)
        {
            int indiceSeleccionado = comboBoxEstado.SelectedIndex;

            if (indiceSeleccionado == 0)
            {
                // Establecer la fecha mínima de reserva como mañana
                dateTimeIngreso.MinDate = DateTime.Today.AddDays(1);

                // Establecer la fecha de salida como mínimo un día después de la fecha de ingreso
                dateTimeSalida.MinDate = dateTimeIngreso.Value.AddDays(1);

            }
            else if (indiceSeleccionado == 1)
            {
                // Establecer la fecha mínima de estadia hoy
                dateTimeIngreso.MinDate = DateTime.Today;

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
    }
}
