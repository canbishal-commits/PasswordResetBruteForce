using System.Security.Cryptography;
using System.Text;

namespace PasswordResetBruteForce.Services
{
    public class PasswordHasher
    {
        private const string Salt = "VU2026";

        public string HashPassword(string password)
        {
            string saltedPassword = password + Salt;

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(saltedPassword);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}