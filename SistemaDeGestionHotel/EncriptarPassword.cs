using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace SistemaDeGestionHotel
{
    public static class EncriptarPassword
    {
        public static string HashPassword(string password)
        {
            // Generar un salt aleatorio
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            // Crear un derivado de contraseña utilizando PBKDF2
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(20); // Tamaño del hash

            // Combinar el salt y el hash en una sola matriz
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            // Convertir la matriz de bytes a una cadena base64
            string hashPassword = Convert.ToBase64String(hashBytes);

            return hashPassword;
        }

        public static bool VerifyPassword(string hashedPassword, string userPassword)
        {
            // Obtener el salt desde la cadena hasheada
            byte[] hashBytes = Convert.FromBase64String(hashedPassword);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Calcular el hash de la contraseña proporcionada
            var pbkdf2 = new Rfc2898DeriveBytes(userPassword, salt, 10000, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(20);

            // Comparar el hash calculado con el hash almacenado
            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    return false; // Las contraseñas no coinciden
                }
            }

            return true; // Las contraseñas coinciden
        }
    }

}

