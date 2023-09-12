using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionHotel
{
    public static class ValidacionTextBox
    {
        public static void ValidarSoloNumeros(TextBox textBox, ErrorProvider errorProvider)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    errorProvider.SetError(textBox, "Solo se permiten números.");
                }
                else
                {
                    errorProvider.SetError(textBox, "");
                }
            };
        }

        public static void ValidarNoVacio(TextBox textBox, ErrorProvider errorProvider)
        {
            textBox.Validating += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    e.Cancel = true;
                    errorProvider.SetError(textBox, "Este campo es obligatorio.");
                }
                else
                {
                    errorProvider.SetError(textBox, "");
                }
            };
        }



    }
    
}
