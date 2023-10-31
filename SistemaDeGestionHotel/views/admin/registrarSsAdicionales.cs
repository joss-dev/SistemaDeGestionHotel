using SistemaDeGestionHotel.Controllers;
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

        ServiciosAdicionalesController servicio_controller = new ServiciosAdicionalesController();

        public registrarSsAdicionales()
        {
            InitializeComponent();

            dataGridView1.DataSource = servicio_controller.GetServiciosAdicionales();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Agregar elementos a la lista desplegable.
            comboBoxEstado.Items.Add("Inactivo");
            comboBoxEstado.Items.Add("Activo");

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
            else
            {
                bool result = servicio_controller.AgregarServicioAdicional(txtNombSs.Text, float.Parse(txtPrecioTotal.Text), comboBoxEstado.SelectedIndex);

                if (result)
                {
                    MessageBox.Show("El servicio fue registrado correctamente", "Notificación", MessageBoxButtons.OK);
                    txtNombSs.Text = String.Empty;
                    txtPrecioTotal.Text = String.Empty;
                    dataGridView1.DataSource = servicio_controller.GetServiciosAdicionales();
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al cargar el servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
