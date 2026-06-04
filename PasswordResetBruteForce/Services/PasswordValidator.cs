namespace PasswordResetBruteForce.Services
{
    public class PasswordValidator
    {
        public bool Validate(string candidatePassword, string targetHash)
        {
            PasswordHasher hasher = new PasswordHasher();

            string candidateHash = hasher.HashPassword(candidatePassword);

            return candidateHash == targetHash;
        }
    }
}