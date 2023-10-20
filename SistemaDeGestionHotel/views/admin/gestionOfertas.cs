using Microsoft.VisualBasic;
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public gestionOfertas()
        {
            InitializeComponent();

            // Agregar elementos a la lista desplegable.
            comboBoxEstado.Items.Add("Activo");
            comboBoxEstado.Items.Add("Inactivo");

            // Establecer los elementos seleccionados por defecto.
            comboBoxEstado.SelectedIndex = 0;
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
            
            // Establecer la fecha mínima de hoy
            dateTimeInicio.MinDate = DateTime.Today;

            // Establecer la fecha de salida como mínimo un día después de la fecha de ingreso
            dateTimeFin.MinDate = dateTimeFin.Value.AddDays(1);
        }

        void cerrar(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                this.Close();
            }
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
    }
}
