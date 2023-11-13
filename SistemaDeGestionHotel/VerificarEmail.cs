using System.Text.RegularExpressions;

namespace SistemaDeGestionHotel
{
    public static class VerificarEmail
    {

        public static bool Verificar_Email(string email)
        {

            // Expresión regular para validar correos electrónicos
            string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

            // Comprobar si el correo electrónico es válido
            bool isValidEmail = Regex.IsMatch(email, pattern);
            return isValidEmail;

        }
    }
}
