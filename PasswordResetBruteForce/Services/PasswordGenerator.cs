using System;
using System.Text;

namespace PasswordResetBruteForce.Services
{
    public class PasswordGenerator
    {
        private readonly Random random = new Random();
        private const string Characters = "abcdefghijklmnopqrstuvwxyz";

        public string GeneratePassword()
        {
            int length = random.Next(4, 6);

            StringBuilder password = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                password.Append(Characters[random.Next(Characters.Length)]);
            }

            return password.ToString();
        }
    }
}