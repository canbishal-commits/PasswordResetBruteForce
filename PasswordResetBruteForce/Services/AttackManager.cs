using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace PasswordResetBruteForce.Services
{
    public class AttackManager
    {
        public long ElapsedMilliseconds { get; private set; }

        public Action<string>? OnAttempt;
        public Action<int>? OnProgress;

        private CancellationTokenSource cancellationTokenSource = new();

        private readonly BruteForceGenerator generator;
        private readonly PasswordValidator validator;

        private string? foundPassword;
        private readonly object lockObject = new();

        private long attempts = 0;

        private const long TotalCombinations = 321272406;
        public AttackManager()
        {
            generator = new BruteForceGenerator();
            validator = new PasswordValidator();
        }

        public string? StartAttack(string targetHash)
        {
            foundPassword = null;
            attempts = 0;

            cancellationTokenSource = new CancellationTokenSource();

            Stopwatch stopwatch = Stopwatch.StartNew();

            Task[] tasks =
            {
                Task.Run(() => SearchPrefixes("abcd", targetHash)),
                Task.Run(() => SearchPrefixes("efgh", targetHash)),
                Task.Run(() => SearchPrefixes("ijkl", targetHash)),
                Task.Run(() => SearchPrefixes("mnop", targetHash)),
                Task.Run(() => SearchPrefixes("qrst", targetHash)),
                Task.Run(() => SearchPrefixes("uvw", targetHash)),
                Task.Run(() => SearchPrefixes("xyz", targetHash))
            };

            Task.WaitAll(tasks);

            stopwatch.Stop();

            ElapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            OnProgress?.Invoke(100);

            return foundPassword;
        }

        public void StopAttack()
        {
            cancellationTokenSource.Cancel();
        }

        private void SearchPrefixes(string prefixes, string targetHash)
        {
            foreach (char prefix in prefixes)
            {
                foreach (string candidate in generator.GenerateCombinationsForPrefix(prefix))
                {
                    long currentAttempts =
                        Interlocked.Increment(ref attempts);

                    if (currentAttempts % 5000 == 0)
                    {
                        OnAttempt?.Invoke(candidate);
                    }

                    if (currentAttempts % 10000 == 0)
                    {
                        int progress =
                            (int)((currentAttempts * 100) / TotalCombinations);

                        OnProgress?.Invoke(
                            Math.Min(progress, 99));
                    }

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

                                OnAttempt?.Invoke(candidate);

                                OnProgress?.Invoke(100);

                                cancellationTokenSource.Cancel();
                            }
                        }

                        return;
                    }
                }
            }
        }
    }
}