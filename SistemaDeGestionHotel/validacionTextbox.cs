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

        public static bool ValidarNoVacio(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true; // Al menos un TextBox está vacío
                }
            }

            return false; // Ningún TextBox está vacío
        }


        public static void ValidarPrecio(TextBox textBox, ErrorProvider errorProvider)
        {
            textBox.KeyPress += (sender, e) =>
            {
                // Permitir solo caracteres numéricos, comas, puntos y teclas de control como Backspace y Delete
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
                {
                    e.Handled = true; // Cancelar la entrada del caracter
                    errorProvider.SetError(textBox, "Ingrese un precio válido.");
                }
                else
                {
                    errorProvider.SetError(textBox, ""); // Limpiar el mensaje de error si es válido
                }
            };
        }

        public static void ValidarTextoConEspaciosYNumeros(TextBox textBox, ErrorProvider errorProvider)
        {
            textBox.KeyPress += (sender, e) =>
            {
                // Permitir solo caracteres de letras, números, espacios y teclas de control como Backspace y Delete
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true; // Cancelar la entrada del carácter
                    errorProvider.SetError(textBox, "Solo se permiten letras, números y espacios.");
                }
                else
                {
                    errorProvider.SetError(textBox, ""); // Limpiar el mensaje de error si es válido
                }
            };
        }


    }
}
