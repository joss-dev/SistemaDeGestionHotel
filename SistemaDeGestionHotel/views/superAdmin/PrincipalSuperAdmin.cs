using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using SistemaDeGestionHotel.views.superAdmin;
using SistemaDeGestionHotel.views.admin;

namespace SistemaDeGestionHotel.views
{
    public partial class PrincipalSuperAdmin : Form
    {
        //declaracion de icono y boton 
        private IconButton currentBtn;
        private Panel leftBorderBtn;


        public PrincipalSuperAdmin()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //abre el form home cuando principalAdmin se abre
            FormsHijos.AbrirFormHija(new Home(), panelContenedor);

            // Establece que el formulario se inicie maximizado
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        //libreria que permite arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        //metodo para resaltar el boton activo
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //desactivamos el boton antes de activarlo
                DisableButton();

                //boton
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(28, 121, 182);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //panel izquierdo
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }


        //metodo para desactivar el resaltado
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(39, 79, 193);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void btnPantallaCompleta_Click(object sender, EventArgs e)
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(34, 81, 111));
            FormsHijos.AbrirFormHija(new Home(), panelContenedor);
        }

        private void PAdmin_Load(object sender, EventArgs e)
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

        private void PAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MouseDownSuperAdmin(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MouseDownPicture(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(34, 81, 111));
            FormsHijos.AbrirFormHija(new FormBackUp(), panelContenedor);
        }

        private void btnRestaurarBD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(34, 81, 111));
            FormsHijos.AbrirFormHija(new FormRestaurarBD(), panelContenedor);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(34, 81, 111));
            FormsHijos.AbrirFormHija(new registroUsuario(), panelContenedor);
        }
    }
}
