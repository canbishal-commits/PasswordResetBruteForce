using System.Collections.Generic;

namespace PasswordResetBruteForce.Services
{
    public class BruteForceGenerator
    {
        private const string Characters = "abcdefghijklmnopqrstuvwxyz";

        public IEnumerable<string> GenerateCombinations()
        {
            for (int length = 1; length <= 5; length++)
            {
                foreach (string combination in GenerateRecursive("", length))
                {
                    yield return combination;
                }
            }
        }
        public IEnumerable<string> GenerateCombinationsForPrefix(char prefix)
        {
            for (int length = 1; length <= 5; length++)
            {
                if (length == 1)
                {
                    yield return prefix.ToString();
                }
                else
                {
                    foreach (string result in GenerateRecursive(prefix.ToString(), length - 1))
                    {
                        yield return result;
                    }
                }
            }
        }
        private IEnumerable<string> GenerateRecursive(string current, int remainingLength)
        {
            if (remainingLength == 0)
            {
                yield return current;
                yield break;
            }

            foreach (char c in Characters)
            {
                foreach (string result in GenerateRecursive(current + c, remainingLength - 1))
                {
                    yield return result;
                }
            }
        }
    }
}