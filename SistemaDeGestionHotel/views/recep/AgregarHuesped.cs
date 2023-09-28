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

            //establece la fecha minima para seleccionar
            dateTimeIngreso.MinDate = DateTime.Today;
            dateTimeSalida.MinDate = DateTime.Today;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidacionTextBox.ValidarNoVacio(TDni, TNombre, TApellido, TCantidadHuespedes))
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
            this.DialogResult = DialogResult.OK;

            // Cerrar el formulario secundario
            this.Close();
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
    }
}
