using Microsoft.VisualBasic;
using SistemaDeGestionHotel.Controllers;
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Verificar si alguno de los campos está incompleto
            if (ValidacionTextBox.ValidarNoVacio(txtMail, txtMotivoConsulta, txtMsjeRecibido))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CargarDatos(object sender, EventArgs e)
        {
            var consultas = consultaController.ObtenerConsultasConUsuarios();

            var datosParaMostrar = consultas.Select(c => new
            {
                IdConsulta = c.IdConsulta,
                Asunto = c.Asunto,
                Mensaje = c.Mensaje,
                FechaMensaje = c.FechaMensaje,
                Nombre = c.IdUsuarioNavigation.Nombre,
                Apellido = c.IdUsuarioNavigation.Apellido,
                CorreoElectronico = c.IdUsuarioNavigation.CorreoElectronico
            }).ToList();

            dataGridView1.DataSource = datosParaMostrar;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
