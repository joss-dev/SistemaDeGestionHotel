using FontAwesome.Sharp;
using SistemaDeGestionHotel.views.admin;
using SistemaDeGestionHotel.views.recep;
using System.Drawing.Text;
using SistemaDeGestionHotel.views;
using SistemaDeGestionHotel.NEntidades;

namespace SistemaDeGestionHotel
{
    public partial class PrincipalRecep : Form
    {

        private Usuario usuarioInicioSesion;

        //declaracion de icono y boton 
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        //variables de arrastrar
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public PrincipalRecep(Usuario usuario)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            usuarioInicioSesion = usuario;

            //abre el form home cuando principalAdmin se abre
            FormsHijos.AbrirFormHija(new HomeRecep(usuarioInicioSesion), panelContenedor);

            // Establece que el formulario se inicie maximizado
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //metodos para arrastrar el formulario
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }



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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(34, 81, 111));
            FormsHijos.AbrirFormHija(new HomeRecep(usuarioInicioSesion), panelContenedor);
        }

        private void btnGestionHabitaciones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(34, 81, 111));
            FormsHijos.AbrirFormHija(new gestionHabitaciones(usuarioInicioSesion), panelContenedor);
        }


        private void btnGestionPagos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(34, 81, 111));
            FormsHijos.AbrirFormHija(new gestionPagos(), panelContenedor);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            login.Show();
            this.Hide();
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnGestionarReservas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(34, 81, 111));
            FormsHijos.AbrirFormHija(new GestionReservas(), panelContenedor);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(34, 81, 111));
            FormsHijos.AbrirFormHija(new registrarServicio(0), panelContenedor);
        }
    }
}
