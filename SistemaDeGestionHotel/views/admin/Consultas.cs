using Microsoft.VisualBasic;
using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;
using System.Data;
using System.Runtime.InteropServices;

namespace SistemaDeGestionHotel.views.admin
{
    public partial class Consultas : Form
    {
        ConsultaController consultaController = new ConsultaController();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Consultas()
        {
            InitializeComponent();

            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
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

        private void Consulta_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void BtnResuelto_Click(object sender, EventArgs e)
        {
            // Verificar si alguno de los campos está incompleto
            if (ValidacionTextBox.ValidarNoVacio(txtMail, txtMotivoConsulta, txtMsjeRecibido))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int idConsulta = -1; // Valor predeterminado si no se selecciona ningún usuario

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Si al menos una fila está seleccionada, obtiene el índice de la primera fila seleccionada
                    int rowIndex = dataGridView1.SelectedRows[0].Index;

                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    idConsulta = int.Parse(row.Cells["IdConsulta"].Value.ToString());
                }
                if (idConsulta != -1)
                {
                    Consultum ConsultaCambioEstado = consultaController.TraerConsultaPorID(idConsulta);

                    if (ConsultaCambioEstado.Estado == 1)
                    {
                        MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("¿Seguro desea marcar como resuelta?", "Confirmacion", MessageBoxButtons.YesNo);
                        if (ask == MsgBoxResult.Yes)
                        {
                            bool result = consultaController.ConsultaResuelta(ConsultaCambioEstado.IdConsulta);
                            if (result)
                            {
                                MessageBox.Show("La consulta ha sido marcada como resuelta", "Confirmado", MessageBoxButtons.OK);

                                idConsulta = -1;
                                this.CargarDatosDataGrid();

                                ConsultaCambioEstado.Estado = 0;
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }else
                    {
                        MessageBox.Show("La consulta ya fue resuelta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    
                }
                else
                {
                    MessageBox.Show("No seleccciono ninguna consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Estado_consulta"].Index)
            {
                // Obtén el valor del estado en la celda actual.
                string Estado = dataGridView1.Rows[e.RowIndex].Cells["Estado_consulta"].Value.ToString();

                // Define los colores para "activo" y "resuelto".
                Color colorActiva = Color.Red;
                Color colorResuelta = Color.Green;

                // Establece el color de fondo basado en el valor del estado.
                if (Estado.Equals("Activa", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = colorActiva;
                }
                else if (Estado.Equals("Resuelta", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = colorResuelta;
                }
                else
                {
                    // Restaura el color de fondo predeterminado para otros valores de estado.
                    e.CellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
                }
            }
        }

        private void CargarDatosDataGrid()
        {
            var consultas = consultaController.ObtenerConsultasConUsuarios();

            var datosParaMostrar = consultas.Select(c => new
            {
                IdConsulta = c.IdConsulta,
                Nombre = c.IdUsuarioNavigation.Nombre,
                Apellido = c.IdUsuarioNavigation.Apellido,
                CorreoElectronico = c.IdUsuarioNavigation.CorreoElectronico,
                Asunto = c.Asunto,
                Mensaje = c.Mensaje,
                FechaMensaje = c.FechaMensaje,
                Estado_consulta = c.Estado == 1 ? "Activa" : "Resuelta"
            }).ToList();

            dataGridView1.DataSource = datosParaMostrar;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["IdConsulta"].HeaderText = "ID";
            dataGridView1.Columns["CorreoElectronico"].HeaderText = "Correo";
            dataGridView1.Columns["FechaMensaje"].HeaderText = "Fecha";
        }

        private void CargarDatos(object sender, EventArgs e)
        {
            this.CargarDatosDataGrid();
        }

        private void CargaDatosAlTextBox(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Accede a los datos de la fila y carga en los TextBox y ComboBox
                txtMail.Text = row.Cells["CorreoElectronico"].Value.ToString();
                txtMotivoConsulta.Text = row.Cells["Asunto"].Value.ToString();
                txtMsjeRecibido.Text = row.Cells["Mensaje"].Value.ToString();

            }
        }
    }
}
