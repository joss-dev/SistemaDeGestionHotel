using SistemaDeGestionHotel.SGHControl;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace SistemaDeGestionHotel
{
    public partial class PrincipalAdmin : Form
    {
        public PrincipalAdmin()
        {
            InitializeComponent();
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
    }
}