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

            // Crear las listas de opciones
            List<string> opciones = new List<string>() { "", "Habitación simple", "Habitación doble", "Habitación triple" };
            List<string> opciones2 = new List<string>() { "", "Libre", "Ocupada", "Habilitada", "Deshabilitada", "Eliminada" };

            // Limpiar los comboBox
            comboBoxTipoHab.Items.Clear();
            comboBoxEstado.Items.Clear();


            // Agregar las opciones a los comboBoxTipoHab & comoBoxEstado
            foreach (string opcion in opciones)
            {
                comboBoxTipoHab.Items.Add(opcion);
            }

            foreach (string opcion2 in opciones2)
            {
                comboBoxEstado.Items.Add(opcion2);
            }
        }

        private void ValidacionNroHabitacion(object sender, EventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(txtNroHab, errorProvider1);
        }

        private void comboBoxTipoHab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoHab.SelectedItem == null || string.IsNullOrEmpty(comboBoxTipoHab.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Seleccione una opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ValidacionCantidadCamas(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(txtCantCamas, errorProvider1);
        }

        private void ValidacionPiso(object sender, EventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(txtPiso, errorProvider1);
        }

        private void ValidacionCosto(object sender, EventArgs e)
        {
            ValidacionTextBox.ValidarPrecio(txtCosto, errorProvider1);
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEstado.SelectedItem == null || string.IsNullOrEmpty(comboBoxEstado.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Seleccione una opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAgregarHabitac_Click(object sender, EventArgs e)
        {
            // Verificar si alguno de los campos está incompleto
            if (ValidacionTextBox.ValidarNoVacio(txtNroHab, txtCantCamas, txtPiso, txtCosto))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                else if (c is ComboBox)
                {
                    // Si el control es un ComboBox, seleccionar el primer elemento (o dejar en blanco)
                    ((ComboBox)c).SelectedIndex = 0;
                }
                else if (c is CheckBox)
                {

                    // Llamar recursivamente a LimpiarCampos para los controles secundarios (si los hay)
                    if (c.HasChildren)
                    {
                        LimpiarCampos(c);
                    }
                }
            }
        }
    }
}
