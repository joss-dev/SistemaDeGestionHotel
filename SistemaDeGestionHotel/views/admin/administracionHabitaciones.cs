using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionHotel.views.admin
{
    public partial class administracionHabitaciones : Form
    {
        public administracionHabitaciones()
        {
            InitializeComponent();
        }

        private void txtNroHab_TextChanged(object sender, EventArgs e)
        {

        }

        private void validarCantidadCamas(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(txtCantCamas, errorProvider1);
        }

        private void btnAgregarHabitac_Click(object sender, EventArgs e)
        {
            // Verificar si alguno de los campos está incompleto
            if (string.IsNullOrEmpty(txtNroHab.Text) || string.IsNullOrEmpty(txtTipoHabitac.Text) || string.IsNullOrEmpty(txtCantCamas.Text) || string.IsNullOrEmpty(txtPiso.Text) || string.IsNullOrEmpty(txtEstado.Text) || string.IsNullOrEmpty(txtCosto.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
