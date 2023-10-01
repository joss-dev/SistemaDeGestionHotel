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
    public partial class FormTarjeta : Form
    {
        public FormTarjeta()
        {
            InitializeComponent();
            comboBoxTarjeta.SelectedIndex = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MsgBoxResult result = (MsgBoxResult)MessageBox.Show("¿Está seguro de que desea cerrar el formulario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == MsgBoxResult.Yes)
            {
                this.DialogResult = DialogResult.OK;

                // Cerrar el formulario secundario
                this.Close();
            }
        }

        private void ValidarNroTarjeta(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(textBoxNroTarjeta, errorProviderNumero);
        }

        private void ValidarFecha(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(textBoxFechaCad, errorProviderNumero);
        }

        private void ValidarTitular(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(textBoxTitular, errorProviderNumero);
        }

        private void ValidarCvv(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(textBoxCvv, errorProviderNumero);
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if(ValidacionTextBox.ValidarNoVacio(textBoxCvv, textBoxFechaCad, textBoxNroTarjeta, textBoxTitular)) {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
