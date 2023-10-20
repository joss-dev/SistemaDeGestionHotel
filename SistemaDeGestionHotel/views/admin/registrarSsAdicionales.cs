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
    public partial class registrarSsAdicionales : Form
    {
        public registrarSsAdicionales()
        {
            InitializeComponent();
        }

        private void ValidacionNombreSs(object sender, EventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(txtNombSs, errorProvider1);
        }



        private void ValidacionCosto(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(txtPrecioTotal, errorProvider1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos(this);
        }

        private void LimpiarCampos(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    // Si el control es un TextBox, limpiar su contenido
                    ((TextBox)c).Text = string.Empty;
                }
                else
                    // Llamar recursivamente a LimpiarCampos para los controles secundarios (si los hay)
                    if (c.HasChildren)
                {
                    LimpiarCampos(c);
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Verificar si alguno de los campos está incompleto
            if (ValidacionTextBox.ValidarNoVacio(txtNombSs, txtPrecioTotal))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
