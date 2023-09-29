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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public gestionMediosPago()
        {
            InitializeComponent();

            // Agregar elementos a las listas desplegables.
            comboBoxTipoMP.Items.Add("Tarjeta de crédito");
            comboBoxTipoMP.Items.Add("Tarjeta de débito");
            comboBoxTipoMP.Items.Add("Efectivo");
            comboBoxTipoMP.Items.Add("Transferencia");

            comboBoxEstadoMP.Items.Add("Activo");
            comboBoxEstadoMP.Items.Add("Inactivo");

            // Establecer los elementos seleccionados por defecto.
            comboBoxTipoMP.SelectedIndex = 0;
            comboBoxEstadoMP.SelectedIndex = 0;

        }



        private void comboBoxTipoMP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoMP.SelectedItem == null || string.IsNullOrEmpty(comboBoxTipoMP.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Seleccione una opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void comboBoxEstadoMP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEstadoMP.SelectedItem == null || string.IsNullOrEmpty(comboBoxEstadoMP.Text))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Seleccione una opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void ValidacionNombre(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(txtNombMP, errorProvider1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

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

        private void GestioMediosPago_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }
    }
}
