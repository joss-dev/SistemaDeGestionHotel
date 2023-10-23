using SistemaDeGestionHotel.Controllers;
using SistemaDeGestionHotel.NEntidades;
using SistemaDeGestionHotel.views;
using System.Runtime.InteropServices;

namespace SistemaDeGestionHotel
{
    public partial class Login : Form
    {

        LoginController login = new LoginController();
        public Login()
        {
            InitializeComponent();
            // Establece la posición de inicio en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void TUsuario_Enter(object sender, EventArgs e)
        {
            if (TUsuario.Text == "Usuario")
            {
                TUsuario.Text = "";
                TUsuario.ForeColor = Color.LightGray;
            }
        }

        private void TUsuario_Leave(object sender, EventArgs e)
        {
            if (TUsuario.Text == "")
            {
                TUsuario.Text = "Usuario";
                TUsuario.ForeColor = Color.DimGray;
            }
        }

        private void TPass_Enter(object sender, EventArgs e)
        {
            if (TPass.Text == "Contraseña")
            {
                TPass.Text = "string.Empty";
                TPass.ForeColor = Color.LightGray;
                TPass.UseSystemPasswordChar = true;
            }
        }

        private void TPass_Leave(object sender, EventArgs e)
        {
            if (TPass.Text == "string.Empty")
            {
                TPass.Text = "Contraseña";
                TPass.ForeColor = Color.DimGray;
                TPass.UseSystemPasswordChar = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Login_KeyDown);
        }

        void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                this.Close();
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (TPass.UseSystemPasswordChar == false)
            {
                TPass.UseSystemPasswordChar = true;
                iconButton1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                TPass.UseSystemPasswordChar = true;
                iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidacionTextBox.ValidarNoVacio(TUsuario, TPass))
            {
                // Mostrar un mensaje de error
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                Usuario usuario = login.IniciarSesion(TUsuario.Text, TPass.Text);

                if (usuario != null)
                {
                    if(usuario.IdPerfilUsuario == 1)
                    {
                        Form form = new PrincipalSuperAdmin();
                        form.Show();
                        this.Hide();
                    }
                    else if(usuario.IdPerfilUsuario == 2)
                    {
                        Form form = new PrincipalAdmin();
                        form.Show();
                        this.Hide();
                    }
                    else if(usuario.IdPerfilUsuario == 3)
                    {
                        Form form = new PrincipalRecep();
                        form.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta o Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
      }
    internal class DLLImportAttribute : Attribute
    {

    }
}
