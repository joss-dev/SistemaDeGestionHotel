using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionHotel.views.recep
{
    public partial class ConsultaDni : Form
    {
        public ConsultaDni()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form agregarHues = new AgregarHuesped();

            agregarHues.StartPosition = FormStartPosition.CenterScreen;

            DialogResult result = agregarHues.ShowDialog();
        }

        private void ValidarDni(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarSoloNumeros(TDni, errorProvider1);
        }

        public string TextoDesdeFormularioOrigen
        {
            get { return TDni.Text; }
        }
    }
}
