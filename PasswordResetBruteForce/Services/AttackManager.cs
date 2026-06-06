using System.Diagnostics;
using System.Threading;



namespace PasswordResetBruteForce.Services
{
    public class AttackManager
    {
        public long ElapsedMilliseconds { get; private set; }
        private CancellationTokenSource cancellationTokenSource = new();

        private readonly BruteForceGenerator generator;
        private readonly PasswordValidator validator;

        public AttackManager()
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
        public void StopAttack()
        {
            cancellationTokenSource.Cancel();
        }
    }
}