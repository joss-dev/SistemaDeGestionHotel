namespace SistemaDeGestionHotel.views
{
    public partial class PrincipalSuperAdmin : Form
    {
        public PrincipalSuperAdmin()
        {
            InitializeComponent();
            // Establece que el formulario se inicie maximizado
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
    }
}
