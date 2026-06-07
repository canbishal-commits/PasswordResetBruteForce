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
            foundPassword = null;

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
                    if (cancellationTokenSource.Token.IsCancellationRequested)
                    {
                        return;
                    }

                    if (validator.Validate(candidate, targetHash))
                    {
                        Console.WriteLine("FOUND PASSWORD: " + candidate);
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
}