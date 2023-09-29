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
    public partial class FormEfectivo : Form
    {
        public FormEfectivo()
        {
            InitializeComponent();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidarEfectivo(object sender, KeyEventArgs e)
        {
            ValidacionTextBox.ValidarPrecio(textBoxEfectivo, errorProvider1);
        }
    }
}
