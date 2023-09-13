using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestionHotel
{
    public static class ValidacionTextBox
    {

        //metodo que permite validar los campos para que solo acepten numeros
        public static void ValidarSoloNumeros(TextBox textBox, ErrorProvider errorProvider)
        {
            textBox.KeyPress += (sender, e) =>
            {
                // Permitir solo caracteres numéricos y teclas de control como Backspace y Delete
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Cancelar la entrada del caracter
                    errorProvider.SetError(textBox, "Solo se permiten números.");
                }
                else
                {
                    errorProvider.SetError(textBox, ""); // Limpiar el mensaje de error si es válido
                }
            };
        }

        //metodo que permite validar los campos para que solo acepten textos con espacio

        public static void ValidarTextoConEspacios(TextBox textBox, ErrorProvider errorProvider)
        {
            textBox.KeyPress += (sender, e) =>
            {
                // Permitir solo caracteres de letras, espacios y teclas de control como Backspace y Delete
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true; // Cancelar la entrada del carácter
                    errorProvider.SetError(textBox, "Solo se permiten letras y espacios.");
                }
                else
                {
                    errorProvider.SetError(textBox, ""); // Limpiar el mensaje de error si es válido
                }
            };
        }

        //metodo que permite validar los campos que no esten vacios

        public static void ValidarNoVacio(TextBox textBox, ErrorProvider errorProvider)
        {
            textBox.Validating += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    e.Cancel = true; // Evitar que el foco salga del TextBox
                    errorProvider.SetError(textBox, "Este campo es obligatorio.");
                }
                else
                {
                    errorProvider.SetError(textBox, ""); // Limpiar el mensaje de error si es válido
                }
            };

        }
    }
}
