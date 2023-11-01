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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionHotel.views.admin
{
    public partial class gestionOfertas : Form
    {
        OfertaRecargoControllers oferta_recargoController = new OfertaRecargoControllers();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public gestionOfertas()
        {
            InitializeComponent();

            dataGridView2.DataSource = oferta_recargoController.ObtenerOfertaRecargo();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dateTimeInicio.Format = DateTimePickerFormat.Custom;
            dateTimeInicio.CustomFormat = "dd/MM/yyyy"; // Formato de fecha

            dateTimeFin.Format = DateTimePickerFormat.Custom;
            dateTimeFin.CustomFormat = "dd/MM/yyyy"; // Formato de fecha

            // Establecer la fecha mínima de reserva como mañana
            dateTimeInicio.MinDate = DateTime.Today;

            // Establecer la fecha de salida como mínimo un día después de la fecha de ingreso
            dateTimeFin.MinDate = dateTimeInicio.Value.Date.AddDays(1);


            // Agregar elementos a la lista desplegable.
            comboBoxEstado.Items.Add("Finalizada");
            comboBoxEstado.Items.Add("Activa");

            // Establecer los elementos seleccionados por defecto.
            comboBoxEstado.SelectedIndex = 1;
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

        private void ValidacionNombre(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(txtNombre, errorProvider1);
        }

        private void ValidacionDescuento(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(txtDescuento, errorProvider1);
        }

        private void ValidacionRecargo(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(txtRecargo, errorProvider1);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Verificar si alguno de los campos está incompleto
            if (ValidacionTextBox.ValidarNoVacio(txtNombre, txtDescuento, txtRecargo))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los valores de los campos de la vista
            string nombre = txtNombre.Text;
            DateTime fechaDesde = dateTimeInicio.Value;  //Value para obtener la fecha seleccionada
            DateTime fechaHasta = dateTimeFin.Value;
            float porcentajeDescuento = float.Parse(txtDescuento.Text);
            float porcentajeRecargo = float.Parse(txtRecargo.Text);

            // Realizar la conversión de DateTime a DATE antes de llamar a CargarOfertaRecargo
            DateTime fechaDesdeConvertida = fechaDesde.Date;
            DateTime fechaHastaConvertida = fechaHasta.Date;

            // Llamar al controlador para cargar la oferta o recargo
            bool exito = oferta_recargoController.CargarOfertaRecargo(nombre, fechaDesdeConvertida, fechaHastaConvertida, comboBoxEstado.SelectedIndex, porcentajeDescuento, porcentajeRecargo);

            if (exito)
            {
                MessageBox.Show("Oferta o recargo registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpia los campos de entrada después de una inserción exitosa si es necesario
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al registrar la oferta o recargo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView2.DataSource = oferta_recargoController.ObtenerOfertaRecargo();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescuento.Clear();
            txtRecargo.Clear();
            // Limpia otros campos si es necesario
        }

        public void CargarDataGrid(object sender, EventArgs e)
        {
            var ofertaRecargo = oferta_recargoController.ObtenerOfertaRecargo();

            var datosParaMostrar = ofertaRecargo.Select(or => new
            {
                IdOfertaRecargo = or.IdOfertaRecargo,
                NombOfertaRecargo = or.NombOfertaRecargo,
                FechaDesde = or.FechaDesde,
                FechaHasta = or.FechaHasta,
                Estado = or.Estado == 1 ? "Activo" : "Finalizada",
                PorcentajeDescuento = or.PorcentajeDescuento,
                PorcentajeRecargo = or.PorcentajeRecargo
            }).ToList();

            dataGridView2.DataSource = datosParaMostrar;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (ValidacionTextBox.ValidarNoVacio(txtNombre, txtDescuento, txtRecargo))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int idOfertaRecargo = -1; // Valor predeterminado si no se selecciona ninguna oferta

                if (dataGridView2.SelectedRows.Count > 0)
                {
                    // Si al menos una fila está seleccionada, obtén el índice de la primera fila seleccionada
                    int rowIndex = dataGridView2.SelectedRows[0].Index;

                    DataGridViewRow row = dataGridView2.Rows[rowIndex];
                    idOfertaRecargo = int.Parse(row.Cells["idOfertaRecargoDataGridViewTextBoxColumn"].Value.ToString());
                }
                if (idOfertaRecargo != -1)
                {
                    OfertasRecargo OREditar = oferta_recargoController.TraerORPorID(idOfertaRecargo);

                    MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Seguro desea editar este concepto?", "Confirmacion de edición", MessageBoxButtons.YesNo);
                    if (ask == MsgBoxResult.Yes)
                    {
                        // Para convertir los valores de descuento y recargo a float.
                        if (float.TryParse(txtDescuento.Text, out float descuento) &&
                            float.TryParse(txtRecargo.Text, out float recargo))
                        {

                            DateTime fechaDesde = dateTimeInicio.Value;  //Value para obtener la fecha seleccionada
                            DateTime fechaHasta = dateTimeFin.Value;

                            // Realizar la conversión de DateTime a DATE
                            DateTime fechaDesdeConvertida = fechaDesde.Date;
                            DateTime fechaHastaConvertida = fechaHasta.Date;

                            int estado = comboBoxEstado.SelectedIndex;

                            bool result = oferta_recargoController.EditarOfertaRecargo(OREditar.IdOfertaRecargo, txtNombre.Text, fechaDesdeConvertida, fechaHastaConvertida, estado, descuento, recargo);
                            if (result)
                            {
                                idOfertaRecargo = -1;
                                dataGridView2.DataSource = oferta_recargoController.ObtenerOfertaRecargo();
                                txtNombre.Text = string.Empty;
                                comboBoxEstado.SelectedIndex = 0; // Establece el índice deseado.
                                txtDescuento.Text = string.Empty;
                                txtRecargo.Text = string.Empty;
                                // Establecer la fecha mínima de hoy
                                dateTimeInicio.MinDate = DateTime.Today;

                                dateTimeFin.MinDate = dateTimeInicio.Value.AddDays(1);
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un error");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No selecciono ningun usuario");
                    }
                }
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {

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

        private void GestioMediosPago_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void gestionOfertas_Load(object sender, EventArgs e)
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

        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }

        private void CargaDatosAlTextBox(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView2.Rows.Count)
            {
                int rowIndex = dataGridView2.SelectedRows[0].Index;
                DataGridViewRow row = dataGridView2.Rows[rowIndex];
                int idOfertaRecargo = int.Parse(row.Cells["idOfertaRecargoDataGridViewTextBoxColumn"].Value.ToString());

                OfertasRecargo OREditar = oferta_recargoController.TraerORPorID(idOfertaRecargo);



                txtNombre.Text = OREditar.NombOfertaRecargo;
                dateTimeInicio.Value = OREditar.FechaDesde;
                dateTimeFin.Value = OREditar.FechaHasta;
                comboBoxEstado.SelectedIndex = OREditar.Estado;
                txtDescuento.Text = OREditar.PorcentajeDescuento.ToString();
                txtRecargo.Text = OREditar.PorcentajeRecargo.ToString();
            }
        }

        private void FechaCambia(object sender, EventArgs e)
        {


            // Establecer la fecha de salida como mínimo un día después de la fecha de ingreso
            dateTimeFin.MinDate = dateTimeInicio.Value.Date.AddDays(1);
        }
    }
}

