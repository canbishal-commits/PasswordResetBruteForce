using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;



namespace PasswordResetBruteForce.Services
{
    public class AttackManager
    {
        public long ElapsedMilliseconds { get; private set; }
        private CancellationTokenSource cancellationTokenSource = new();

        private readonly BruteForceGenerator generator;
        private readonly PasswordValidator validator;
        private string? foundPassword;
        private readonly object lockObject = new();

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
                if (cancellationTokenSource.Token.IsCancellationRequested)
                {
                    return null;
                }
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
        private void SearchPrefix(char prefix, string targetHash)
        {
            foreach (string candidate in generator.GenerateCombinationsForPrefix(prefix))
            {
                if (cancellationTokenSource.Token.IsCancellationRequested)
                {
                    return;
                }

                if (validator.Validate(candidate, targetHash))
                {
                    lock (lockObject)
                    {
                        if (foundPassword == null)
                        {
                            foundPassword = candidate;
                            cancellationTokenSource.Cancel();
                        }
                    }

                    return;
                }
            }
        }
    }

}