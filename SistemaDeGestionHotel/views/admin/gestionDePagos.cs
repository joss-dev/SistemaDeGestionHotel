namespace SistemaDeGestionHotel.views.admin
{
    public partial class gestionDePagos : Form
    {
        private Form formularioAbierto = null;

        public gestionDePagos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void AbrirFormulario(Form formulario)
        {
            if (formularioAbierto == null || formularioAbierto.IsDisposed)
            {
                // El formulario no está abierto o está cerrado, abre el formulario especificado
                formularioAbierto = formulario;
                formularioAbierto.Owner = this; // Establecer el formulario principal como propietario
                formularioAbierto.FormClosed += Formulario_FormClosed; // Manejar el evento FormClosed
                formularioAbierto.ShowDialog();
            }
            else
            {
                // El formulario ya está abierto, trae el formulario existente al frente
                formularioAbierto.BringToFront();
            }
        }

        private void Formulario_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cuando se cierra el formulario, establece la variable formularioAbierto como nula
            formularioAbierto = null;
        }

        private void btnMP_Click(object sender, EventArgs e)
        {
            // Llama a AbrirFormulario con el formulario gestionMediosPago
            AbrirFormulario(new gestionMediosPago());
        }

        private void btnOR_Click(object sender, EventArgs e)
        {
            // Llama a AbrirFormulario con el formulario gestionOfertas
            AbrirFormulario(new gestionOfertas());
        }

        private void gestionDePagos_Load(object sender, EventArgs e)
        {

        }
    }
}
