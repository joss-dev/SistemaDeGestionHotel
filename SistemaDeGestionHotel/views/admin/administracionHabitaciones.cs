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

namespace SistemaDeGestionHotel.views.admin
{
    public partial class administracionHabitaciones : Form
    {

        TipoHabitacionController c_tipoHabitacion = new TipoHabitacionController();
        EstadoHabitacionController c_estadoHabitacion = new EstadoHabitacionController();
        HabitacionController c_habitacion = new HabitacionController();
        PisoController c_piso = new PisoController();
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

            comboBoxEstado.Enabled = false;
            comboBoxEstado.SelectedIndex = 0;
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
            if (ValidacionTextBox.ValidarNoVacio(txtNroHab, txtCantCamas, txtCosto) || comboBoxPiso.SelectedIndex < 0)
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!c_habitacion.ExisteNroHabitacionYpiso(int.Parse(txtNroHab.Text), comboBoxPiso.SelectedIndex + 1))
                {
                    if (c_habitacion.AgregarHabitacion(int.Parse(txtNroHab.Text), int.Parse(txtCantCamas.Text), float.Parse(txtCosto.Text), comboBoxEstado.SelectedIndex + 1, comboBoxTipoHab.SelectedIndex + 1, comboBoxPiso.SelectedIndex + 1))
                    {
                        MessageBox.Show("La habitación se registro correctamente!");
                        this.CargarDatosDataGrid();
                        txtNroHab.Text = String.Empty;
                        txtCantCamas.Text = String.Empty;
                        txtCosto.Text = String.Empty;
                        comboBoxPiso.SelectedIndex = 0;
                        comboBoxEstado.SelectedIndex = 0;
                        comboBoxTipoHab.SelectedIndex = 0;

                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al registrar la habitacion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El nro de habitacion ya se encuentra registrada en este piso!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dataGridView1.Columns["IDHabitacion"].HeaderText = "ID";
            dataGridView1.Columns["NroHabitacion"].HeaderText = "Nro Habitación";
            dataGridView1.Columns["CantidadCamas"].HeaderText = "Cant. Camas";
            dataGridView1.Columns["NroPiso"].HeaderText = "Piso";
            dataGridView1.Columns["TipoHabitacion"].HeaderText = "Tipo";

        }

        private void CargarDatos(object sender, EventArgs e)
        {
            this.CargarDatosDataGrid();

            List<Piso> pisos = c_piso.GetPisos();

            foreach (Piso p in pisos)
            {
                comboBoxPiso.Items.Add(p.NroPiso);
            }

        }

        private void CargaDatosTextBox(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Accede a los datos de la fila y carga en los TextBox y ComboBox
                txtNroHab.Text = row.Cells["NroHabitacion"].Value.ToString();
                comboBoxPiso.SelectedIndex = int.Parse(row.Cells["NroPiso"].Value.ToString()) - 1;
                txtCantCamas.Text = row.Cells["CantidadCamas"].Value.ToString();
                txtCosto.Text = row.Cells["Precio"].Value.ToString();
                comboBoxEstado.SelectedItem = row.Cells["Estado"].Value.ToString();
                comboBoxTipoHab.SelectedItem = row.Cells["TipoHabitacion"].Value.ToString();
            }
        }

        private void btnDeshabHabitacion_Click(object sender, EventArgs e)
        {
            int idHab = -1; // Valor predeterminado si no se selecciona ningúna habitacion

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Si al menos una fila está seleccionada, obtén el índice de la primera fila seleccionada
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                idHab = int.Parse(row.Cells["IDHabitacion"].Value.ToString());
            }
            if (idHab != -1)
            {
                Habitacion habitacion = c_habitacion.GetHabitacionByID(idHab);

                MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro desea deshabilitar la habitacion ID " + habitacion.IdHabitacion.ToString() + "?", "Confirmacion de edición", MessageBoxButtons.YesNo);
                if (ask == MsgBoxResult.Yes)
                {
                    if (c_habitacion.GetHabitacionByID(idHab).IdEstado != 4)
                    {
                        bool result = c_habitacion.DeshabilitarHabitacion(idHab);
                        if (result)
                        {
                            MessageBox.Show("La habitacion: " + habitacion.IdHabitacion.ToString() + " se deshabilito correctamente", "Confirmado", MessageBoxButtons.OK);

                            idHab = -1;

                            this.CargarDatosDataGrid();

                            txtCantCamas.Text = String.Empty;
                            txtCosto.Text = String.Empty;
                            txtNroHab.Text = String.Empty;
                            comboBoxPiso.SelectedIndex = 0;
                            comboBoxEstado.SelectedIndex = 0;
                            comboBoxTipoHab.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La habitacion ya se encuentra deshabilitada");
                    }

                }
            }
            else
            {
                MessageBox.Show("No selecciono ninguna habitacion");
            }
        }

        private void FormatoDataGrid(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //agrega color a las filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Especifica el nombre de la columna que contiene el valor para determinar el color
                string columnName = "EstadoNro";

                // Comprueba si la columna actual es la que deseas evaluar
                if (dataGridView1.Columns[e.ColumnIndex].Name == columnName)
                {
                    // Obtiene el valor de la celda actual
                    int cellValue = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

                    // Cambia el color de fondo de la fila en función del valor de la celda
                    if (cellValue == 5)
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        // Restablece los colores predeterminados si no se cumple ninguna condición
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                    }
                }
            }

        }

        private void btnHabilitarHabitacion_Click(object sender, EventArgs e)
        {
            int idHab = -1; // Valor predeterminado si no se selecciona ningúna habitacion

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Si al menos una fila está seleccionada, obtén el índice de la primera fila seleccionada
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                idHab = int.Parse(row.Cells["IDHabitacion"].Value.ToString());
            }
            if (idHab != -1)
            {
                Habitacion habitacion = c_habitacion.GetHabitacionByID(idHab);

                MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro desea habilitar la habitacion ID " + habitacion.IdHabitacion.ToString() + "?", "Confirmacion de edición", MessageBoxButtons.YesNo);
                if (ask == MsgBoxResult.Yes)
                {
                    if (c_habitacion.GetHabitacionByID(idHab).IdEstado == 4 || c_habitacion.GetHabitacionByID(idHab).IdEstado == 5)
                    {
                        bool result = c_habitacion.AltaHabitacion(idHab);
                        if (result)
                        {
                            MessageBox.Show("La habitacion: " + habitacion.IdHabitacion.ToString() + " se habilito correctamente", "Confirmado", MessageBoxButtons.OK);

                            idHab = -1;

                            this.CargarDatosDataGrid();

                            txtCantCamas.Text = String.Empty;
                            txtCosto.Text = String.Empty;
                            txtNroHab.Text = String.Empty;
                            comboBoxPiso.SelectedIndex = 0;
                            comboBoxEstado.SelectedIndex = 0;
                            comboBoxTipoHab.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La habitacion ya se encuentra habilitada");
                    }

                }
            }
            else
            {
                MessageBox.Show("No selecciono ninguna habitacion");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idHab = -1; // Valor predeterminado si no se selecciona ningúna habitacion

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Si al menos una fila está seleccionada, obtén el índice de la primera fila seleccionada
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                idHab = int.Parse(row.Cells["IDHabitacion"].Value.ToString());
            }
            if (idHab != -1)
            {
                Habitacion habitacion = c_habitacion.GetHabitacionByID(idHab);

                MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro desea eliminar la habitacion ID " + habitacion.IdHabitacion.ToString() + "?", "Confirmacion de edición", MessageBoxButtons.YesNo);
                if (ask == MsgBoxResult.Yes)
                {
                    if (c_habitacion.GetHabitacionByID(idHab).IdEstado != 5)
                    {
                        bool result = c_habitacion.BajaHabitacion(idHab);
                        if (result)
                        {
                            MessageBox.Show("La habitacion: " + habitacion.IdHabitacion.ToString() + " se elimino correctamente", "Confirmado", MessageBoxButtons.OK);

                            idHab = -1;

                            this.CargarDatosDataGrid();

                            txtCantCamas.Text = String.Empty;
                            txtCosto.Text = String.Empty;
                            txtNroHab.Text = String.Empty;
                            comboBoxPiso.SelectedIndex = 0;
                            comboBoxEstado.SelectedIndex = 0;
                            comboBoxTipoHab.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La habitacion ya se encuentra eliminada");
                    }

                }
            }
            else
            {
                MessageBox.Show("No selecciono ninguna habitacion");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidacionTextBox.ValidarNoVacio(txtNroHab, txtCosto, txtCantCamas) || comboBoxPiso.SelectedIndex < 0)
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int idhab = -1; // Valor predeterminado si no se selecciona ningúna habitacion

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Si al menos una fila está seleccionada, obtén el índice de la primera fila seleccionada
                    int rowIndex = dataGridView1.SelectedRows[0].Index;

                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    idhab = int.Parse(row.Cells["IDHabitacion"].Value.ToString());
                }
                if (idhab != -1)
                {
                    Habitacion habitacionEditar = c_habitacion.GetHabitacionByID(idhab);

                    MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro desea editar la habitacion con ID " + habitacionEditar.IdHabitacion.ToString() + "?", "Confirmacion de edición", MessageBoxButtons.YesNo);
                    if (ask == MsgBoxResult.Yes)
                    {

                        if (!c_habitacion.ExisteNroHabitacionYpiso(int.Parse(txtNroHab.Text), comboBoxPiso.SelectedIndex + 1))
                        {
                            bool result = c_habitacion.EditarHabitacion(habitacionEditar.IdHabitacion, int.Parse(txtNroHab.Text), int.Parse(txtCantCamas.Text), float.Parse(txtCosto.Text), comboBoxEstado.SelectedIndex + 1, comboBoxTipoHab.SelectedIndex + 1, comboBoxPiso.SelectedIndex + 1);
                            if (result)
                            {
                                MessageBox.Show("La habitacion con ID: " + habitacionEditar.IdHabitacion.ToString() + " se edito correctamente", "Confirmado", MessageBoxButtons.OK);

                                idhab = -1;
                                this.CargarDatosDataGrid();
                                txtCantCamas.Text = String.Empty;
                                txtCosto.Text = String.Empty;
                                txtNroHab.Text = String.Empty;
                                comboBoxPiso.SelectedIndex = 0;
                                comboBoxEstado.SelectedIndex = 0;
                                comboBoxTipoHab.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El nro de habitacion ya se encuentra registrada en este piso!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }   
                    }
                }
                else
                {
                    MessageBox.Show("No selecciono ninguna habitacion");
                }
            }
        }
    }
}
