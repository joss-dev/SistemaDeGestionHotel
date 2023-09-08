using FontAwesome.Sharp;
using SistemaDeGestionHotel.views.admin;

namespace SistemaDeGestionHotel
{
    public partial class PrincipalRecep : Form
    {
        //declaracion de icono y boton 
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        //variables de arrastrar
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public PrincipalRecep()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
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
        }

        private void btnGestionHabitaciones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(34, 81, 111));
            Form h = new gestionHabitaciones();

            AbrirFormHija(h);
        }

        private void btnRegistrarServicios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(34, 81, 111));
        }

        private void btnGestionPagos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(34, 81, 111));
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AbrirFormHija(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = (Form)formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PantallaCompleta(Form form)
        {
            if (form != null)
            {
                form.WindowState = FormWindowState.Normal; // Restaurar el estado del formulario si estaba minimizado o maximizado
                form.FormBorderStyle = FormBorderStyle.None; // Sin bordes
                form.WindowState = FormWindowState.Maximized; // Maximizar el formulario
                form.TopMost = true; // Mantener el formulario en la parte superior
            }
        }


        private void btnPantallaCompleta_Click(object sender, EventArgs e)
        {
            this.PantallaCompleta(this);
        }
    }
}
