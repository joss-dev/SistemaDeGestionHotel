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

namespace SistemaDeGestionHotel.views.admin
{
    public partial class registrarSsAdicionales : Form
    {

        ServiciosAdicionalesController servicio_controller = new ServiciosAdicionalesController();

        public registrarSsAdicionales()
        {
            InitializeComponent();

            this.CargarElDataGrid();



        }

        private void ValidacionNombreSs(object sender, EventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(txtNombSs, errorProvider1);
        }

        private void CargarElDataGrid()
        {

            List<ServiciosAdicionale> servicios = servicio_controller.GetServiciosAdicionales();

            dataGridView1.DataSource = servicios;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["IdServicioAdic"].HeaderText = "ID";
            dataGridView1.Columns["NombServicio"].HeaderText = "Nombre";
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
                bool result = servicio_controller.AgregarServicioAdicional(txtNombSs.Text, float.Parse(txtPrecioTotal.Text));

                if (result)
                {
                    MessageBox.Show("El servicio fue registrado correctamente", "Notificación", MessageBoxButtons.OK);
                    txtNombSs.Text = String.Empty;
                    txtPrecioTotal.Text = String.Empty;
                    this.CargarElDataGrid();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al cargar el servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
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
                int idServicio = -1; // Valor predeterminado si no se selecciona ningún usuario

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Si al menos una fila está seleccionada, obtén el índice de la primera fila seleccionada
                    int rowIndex = dataGridView1.SelectedRows[0].Index;

                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    idServicio = int.Parse(row.Cells["IdServicioAdic"].Value.ToString());
                }
                if (idServicio != -1)
                {
                    ServiciosAdicionale servicioEditar = servicio_controller.GetServicioAdicionalByID(idServicio);

                    MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro desea editar este Servicio?", "Confirmacion de edición", MessageBoxButtons.YesNo);

                    if (ask == MsgBoxResult.Yes)
                    {
                        bool result = servicio_controller.EditarServicioAdicional(servicioEditar.IdServicioAdic, txtNombSs.Text, float.Parse(txtPrecioTotal.Text));

                        if (result)
                        {
                            idServicio = -1;
                            MessageBox.Show("El servicio fue editado correctamente", "Notificación", MessageBoxButtons.OK);
                            txtNombSs.Text = String.Empty;
                            txtPrecioTotal.Text = String.Empty;
                            this.CargarElDataGrid();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error al editar el servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No selecciono ningun servicio");
                }

            }
        }

        private void CargarDataGrid(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Accede a los datos de la fila y carga en los TextBox y ComboBox
                txtNombSs.Text = row.Cells["NombServicio"].Value.ToString();
                txtPrecioTotal.Text = row.Cells["Precio"].Value.ToString();

            }
        }

        private void btnDeshabHabitacion_Click(object sender, EventArgs e)
        {
            int idServicio = -1; // Valor predeterminado si no se selecciona ningún usuario

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Si al menos una fila está seleccionada, obtén el índice de la primera fila seleccionada
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                idServicio = int.Parse(row.Cells["IdServicioAdic"].Value.ToString());
            }
            if (idServicio != -1)
            {
                ServiciosAdicionale servicioBaja = servicio_controller.GetServicioAdicionalByID(idServicio);

                MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro desea deshabilitar este Servicio?", "Confirmacion de edición", MessageBoxButtons.YesNo);

                if (ask == MsgBoxResult.Yes)
                {
                    bool result = servicio_controller.BajaServicioAdicional(servicioBaja.IdServicioAdic);

                    if (result)
                    {
                        idServicio = -1;
                        MessageBox.Show("El servicio fue deshabilitado correctamente", "Notificación", MessageBoxButtons.OK);
                        txtNombSs.Text = String.Empty;
                        txtPrecioTotal.Text = String.Empty;
                        this.CargarElDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al deshabilitar el servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No selecciono ningun servicio");
            }
        }

        private void btnHabilitarHabitacion_Click(object sender, EventArgs e)
        {
            int idServicio = -1; // Valor predeterminado si no se selecciona ningún usuario

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Si al menos una fila está seleccionada, obtén el índice de la primera fila seleccionada
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                idServicio = int.Parse(row.Cells["IdServicioAdic"].Value.ToString());
            }
            if (idServicio != -1)
            {
                ServiciosAdicionale servicioAlta = servicio_controller.GetServicioAdicionalByID(idServicio);

                MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro desea habilitar este Servicio?", "Confirmacion de edición", MessageBoxButtons.YesNo);

                if (ask == MsgBoxResult.Yes)
                {
                    bool result = servicio_controller.AltaServicioAdicional(servicioAlta.IdServicioAdic);

                    if (result)
                    {
                        idServicio = -1;
                        MessageBox.Show("El servicio fue habilitado correctamente", "Notificación", MessageBoxButtons.OK);
                        txtNombSs.Text = String.Empty;
                        txtPrecioTotal.Text = String.Empty;
                        this.CargarElDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al habilitar el servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No selecciono ningun servicio");
            }
        }

        private void DarFormato(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["estadoDataGridViewTextBoxColumn"].Index)
            {
                e.Value = (int)e.Value == 0 ? "Inactivo" : "Activo";
            }
        }
    }
}
