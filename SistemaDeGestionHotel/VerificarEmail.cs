using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
