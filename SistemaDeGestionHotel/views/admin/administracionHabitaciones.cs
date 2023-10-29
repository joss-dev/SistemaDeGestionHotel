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

namespace SistemaDeGestionHotel.views.admin
{
    public partial class administracionHabitaciones : Form
    {

        TipoHabitacionController c_tipoHabitacion = new TipoHabitacionController();
        EstadoHabitacionController c_estadoHabitacion = new EstadoHabitacionController();
        HabitacionController c_habitacion = new HabitacionController();

        public administracionHabitaciones()
        {
            InitializeComponent();


            List<String> tipoHabitaciones = c_tipoHabitacion.GetTiposHabitacion();
            List<String> estadoHabitaciones = c_estadoHabitacion.GetEstadosHabitaciones();

            // Limpiar los comboBox
            comboBoxTipoHab.Items.Clear();
            comboBoxEstado.Items.Clear();

            // Agregar las opciones a los comboBoxTipoHab & comoBoxEstado
            foreach (string opcion in tipoHabitaciones)
            {
                comboBoxTipoHab.Items.Add(opcion);
            }

            foreach (string opcion2 in estadoHabitaciones)
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
            else
            {
                if (c_habitacion.AgregarHabitacion(int.Parse(txtNroHab.Text), int.Parse(txtCantCamas.Text), float.Parse(txtCosto.Text), comboBoxEstado.SelectedIndex + 1, comboBoxTipoHab.SelectedIndex + 1, int.Parse(txtPiso.Text)))
                {
                    MessageBox.Show("La habitación se registro correctamente!");
                    this.CargarDatosDataGrid();
                    txtNroHab.Text = String.Empty;
                    txtCantCamas.Text = String.Empty;
                    txtCosto.Text = String.Empty;
                    txtPiso.Text = String.Empty;
                    comboBoxEstado.SelectedIndex = 0;
                    comboBoxTipoHab.SelectedIndex = 0;

                }
                else
                {
                    MessageBox.Show("Ocurrio un error al registrar la habitacion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void CargarDatosDataGrid()
        {
            var habitaciones = c_habitacion.GetHabitaciones();


            var habitacionesParaMostrar = habitaciones.Select(c => new
            {
                IDHabitacion = c.IdHabitacion,
                NroHabitacion = c.NroHabitacion,
                CantidadCamas = c.CantidadCamas,
                Precio = c.Precio,
                NroPiso = c.IdPiso,
                Estado = c.IdEstadoNavigation.NombEstado,
                TipoHabitacion = c.IdTipoHabNavigation.NombTipo
            }).ToList();

            dataGridView1.DataSource = habitacionesParaMostrar;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarDatos(object sender, EventArgs e)
        {
            this.CargarDatosDataGrid();
        }

        private void CargaDatosTextBox(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Accede a los datos de la fila y carga en los TextBox y ComboBox
                txtNroHab.Text = row.Cells["NroHabitacion"].Value.ToString();
                txtPiso.Text = row.Cells["NroPiso"].Value.ToString();
                txtCantCamas.Text = row.Cells["CantidadCamas"].Value.ToString();
                txtCosto.Text = row.Cells["Precio"].Value.ToString();
                comboBoxEstado.SelectedItem = row.Cells["Estado"].Value.ToString();
                comboBoxTipoHab.SelectedItem = row.Cells["TipoHabitacion"].Value.ToString();
            }
        }
    }
}
