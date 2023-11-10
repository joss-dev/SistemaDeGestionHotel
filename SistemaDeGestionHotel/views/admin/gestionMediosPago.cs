using Microsoft.VisualBasic;
using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionHotel.views.admin
{
    public partial class gestionMediosPago : Form
    {
        MedioPagoController Medio_pagoController = new MedioPagoController();
        TipoMedioPagoController Tipo_medioPago = new TipoMedioPagoController();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public gestionMediosPago()
        {
            InitializeComponent();

            this.CargarDatosDataGrid();

            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);

            List<String> tiposMedioPago = Tipo_medioPago.GetTiposMediosPagos();


            foreach (string opcion in tiposMedioPago)
            {
                comboBoxTipoMP.Items.Add(opcion);
            }


            comboBoxEstadoMP.Items.Add("Inactivo");
            comboBoxEstadoMP.Items.Add("Activo");

            // Establecer los elementos seleccionados por defecto.
            comboBoxTipoMP.SelectedIndex = 0;

            // Establecer el valor predeterminado en el ComboBox de Estado basado en la base de datos
            comboBoxEstadoMP.SelectedIndex = 1; // Asume que 1   representa "Activo" en tu ComboBox

        }

        private void ValidacionNombre(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(txtNombMP, errorProvider1);
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Verificar si alguno de los campos está incompleto
            if (ValidacionTextBox.ValidarNoVacio(txtNombMP) || comboBoxTipoMP.SelectedIndex < 0 || comboBoxEstadoMP.SelectedIndex < 0)
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool registroExitoso = Medio_pagoController.RegistrarMedioPago(txtNombMP.Text, comboBoxTipoMP.SelectedIndex + 1, comboBoxEstadoMP.SelectedIndex);

            if (registroExitoso)
            {
                MessageBox.Show("El medio de pago se registró correctamente", "Guardar", MessageBoxButtons.OK);
                txtNombMP.Text = string.Empty;
                comboBoxTipoMP.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Hubo un error al registrar el medio de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataGridView2.DataSource = Medio_pagoController.ObtenerMedioPago();
        }

        public void CargarDataGrid(object sender, EventArgs e)
        {
            var mediosPago = Medio_pagoController.ObtenerMedioPago();

            var datosParaMostrar = mediosPago.Select(mp => new
            {
                IdMedioPago = mp.IdMedioPago,
                Nombre = mp.Nombre,
                Tipo_medioPago = mp.IdTipoMedioPagoNavigation.NombMedioPago,
                Estado_MP = mp.Estado == 1 ? "Activo" : "Desactivado"
            }).ToList();

            this.CargarDatosDataGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (ValidacionTextBox.ValidarNoVacio(txtNombMP) || comboBoxTipoMP.SelectedIndex < 0 || comboBoxEstadoMP.SelectedIndex < 0)
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int idMedioPago = -1; // Valor predeterminado si no se selecciona ningún usuario

                if (dataGridView2.SelectedRows.Count > 0)
                {
                    // Si al menos una fila está seleccionada, obtén el índice de la primera fila seleccionada
                    int rowIndex = dataGridView2.SelectedRows[0].Index;

                    DataGridViewRow row = dataGridView2.Rows[rowIndex];
                    idMedioPago = int.Parse(row.Cells["IdMedioPago"].Value.ToString());
                }
                if (idMedioPago != -1)
                {
                    MediosPago MPEditar = Medio_pagoController.TraerMPPorID(idMedioPago);

                    MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro desea editar este Medio de Pago?", "Confirmacion de edición", MessageBoxButtons.YesNo);
                    if (ask == MsgBoxResult.Yes)
                    {
                        bool result = Medio_pagoController.EditarMedioPago(MPEditar.IdMedioPago, txtNombMP.Text, comboBoxTipoMP.SelectedIndex + 1, comboBoxEstadoMP.SelectedIndex);
                        if (result)
                        {
                            idMedioPago = -1;
                            this.CargarDatosDataGrid();

                            txtNombMP.Text = string.Empty;
                            comboBoxTipoMP.SelectedIndex = 0;
                            comboBoxEstadoMP.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error al editar el medio de pago");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No selecciono ningun medio de pago");
                }
            }
        }


        private void CargarDatosDataGrid()
        {
            var tipoMediosPago = Medio_pagoController.ObtenerMedioPago();

            var datosParaMostrar = tipoMediosPago.Select(c => new
            {
                IdMedioPago = c.IdMedioPago,
                Nombre = c.Nombre,
                MedioPagoNombre = c.IdTipoMedioPagoNavigation.NombMedioPago,
                Estado = c.Estado == 1 ? "Activo" : "Inactivo"
            }).ToList();

            dataGridView2.DataSource = datosParaMostrar;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.Columns["IdMedioPago"].HeaderText = "ID";
            dataGridView2.Columns["MedioPagoNombre"].HeaderText = "Nombre";
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView2.SelectedRows[0].Index;
                DataGridViewRow row = dataGridView2.Rows[rowIndex];
                int idMedioPago = int.Parse(row.Cells["IdMedioPago"].Value.ToString());

                MediosPago MPEditar = Medio_pagoController.TraerMPPorID(idMedioPago);

                txtNombMP.Text = MPEditar.Nombre;
                comboBoxTipoMP.SelectedIndex = MPEditar.IdTipoMedioPago - 1;
                comboBoxEstadoMP.SelectedIndex = MPEditar.Estado;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MsgBoxResult result = (MsgBoxResult)MessageBox.Show("¿Está seguro de que desea cerrar el formulario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == MsgBoxResult.Yes)
            {
                this.DialogResult = DialogResult.OK;

                // Cerrar el formulario secundario
                this.Close();
            }
        }

        private void gestionMediosPago_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(cerrar);
        }

        void cerrar(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                this.Close();
            }
        }

        private void GestionMediosPago_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            MsgBoxResult result = (MsgBoxResult)MessageBox.Show("¿Está seguro de que desea cerrar el formulario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == MsgBoxResult.Yes)
            {
                this.DialogResult = DialogResult.OK;

                // Cerrar el formulario secundario
                this.Close();
            }
        }
    }
}
