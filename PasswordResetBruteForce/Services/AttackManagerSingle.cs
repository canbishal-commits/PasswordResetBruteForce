using System.Diagnostics;

namespace PasswordResetBruteForce.Services
{
    public class AttackManagerSingle
    {
        public long ElapsedMilliseconds { get; private set; }

        private readonly BruteForceGenerator generator;
        private readonly PasswordValidator validator;

        public AttackManagerSingle()
        {
            generator = new BruteForceGenerator();
            validator = new PasswordValidator();
        }

        public string? StartAttack(string targetHash)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            foreach (string candidate in generator.GenerateCombinations())
            {
                if (validator.Validate(candidate, targetHash))
                {
                    stopwatch.Stop();

                    ElapsedMilliseconds = stopwatch.ElapsedMilliseconds;

                    return candidate;
                }
            }

            stopwatch.Stop();

            ElapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            return null;
        }
    }
}