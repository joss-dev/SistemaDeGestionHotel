using System.Security.Cryptography;
using System.Text;


namespace SistemaDeGestionHotel
{
    public static class EncriptarPassword
    {
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public static bool VerifyPassword(string enteredPassword, string storedHashedPassword)
        {
            string enteredHashedPassword = HashPassword(enteredPassword);
            return string.Equals(enteredHashedPassword, storedHashedPassword, StringComparison.OrdinalIgnoreCase);
        }
    }
}

