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

namespace SistemaDeGestionHotel.views.recep
{
    

    public partial class consultaSoporte : Form
    {

        ConsultaController c_consulta = new ConsultaController();

        private Usuario usuarioInicioSesion;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public consultaSoporte(Usuario usuario)
        {
            InitializeComponent();
            usuarioInicioSesion = usuario;

            txtNombre.Text = usuarioInicioSesion.Nombre;
            txtApellido.Text = usuarioInicioSesion.Apellido;
            txtMail.Text = usuarioInicioSesion.CorreoElectronico;

        }

        private void ValidarMail(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(txtMail, errorProvider1);
        }

        private void ValidarMotivo(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(txtMotivo, errorProvider1);
        }

        private void ValidarMensaje(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarTextoConEspacios(txtMsje, errorProvider1);
        }



        private void ConsultaSoporte_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtMotivo.Clear();
            this.txtMsje.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si alguno de los campos está incompleto
            if (ValidacionTextBox.ValidarNoVacio(txtMail, txtMotivo, txtMsje, txtNombre, txtApellido))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else
            {
                if(c_consulta.EnviarMensaje(usuarioInicioSesion.IdUsuario, txtMotivo.Text, txtMsje.Text))
                {
                    MessageBox.Show("El mensaje se envio correctamente!");
                    txtMotivo.Text = string.Empty;
                    txtMsje.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al enviar el mensaje!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
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
