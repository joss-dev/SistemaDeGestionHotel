using SistemaDeGestionHotel.SGHControl;
using System.ComponentModel;
using System.Runtime.InteropServices;
using SistemaDeGestionHotel.views;
using SistemaDeGestionHotel.views.admin;
using FontAwesome.Sharp;

namespace SistemaDeGestionHotel
{


    public partial class PrincipalAdmin : Form
    {
        //declaracion de icono y boton 
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public PrincipalAdmin()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //abre el form home cuando principalAdmin se abre
            FormsHijos.AbrirFormHija(new Home(), panelCont);



            // Establece que el formulario se inicie maximizado
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

        private void PrincipalAdmin_Load(object sender, EventArgs e)
        {
            IContainer container = this.Container; // Usa el contenedor del formulario actual
            if (container == null)
            {
                container = new Container();
            }
            else
            {
                var dropDownMenu = new SGHDropDownMenu(container);
                dropDownMenu.IsMainMenu = true;
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(34, 81, 111));
            FormsHijos.AbrirFormHija(new registroUsuario(), panelCont);
            ToolStripDropDown SGHDropDownMenu = new ToolStripDropDown();

            // Crear elementos del menú
            ToolStripMenuItem item1 = new ToolStripMenuItem("Opción 1");
            ToolStripMenuItem item2 = new ToolStripMenuItem("Opción 2");
            ToolStripMenuItem item3 = new ToolStripMenuItem("Opción 3");

            // Añadir los elementos al menú
            SGHDropDownMenu.Items.Add(item1);
            SGHDropDownMenu.Items.Add(item2);
            SGHDropDownMenu.Items.Add(item3);

            // Mostrar el menú
            SGHDropDownMenu.Show(btnUsuarios, btnUsuarios.Width, 0);
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

        private void btnPagos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(34, 81, 111));
            FormsHijos.AbrirFormHija(new gestionDePagos(), panelCont);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(34, 81, 111));
            FormsHijos.AbrirFormHija(new Home(), panelCont);
        }

        private void btnRegistrarServicios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(34, 81, 111));
            FormsHijos.AbrirFormHija(new registrarSsAdicionales(), panelCont);
        }

        private void btnAdmHabitaciones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(34, 81, 111));
            FormsHijos.AbrirFormHija(new administracionHabitaciones(), panelCont);
        }
    }
}