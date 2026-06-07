using System.Threading.Tasks;
using PasswordResetBruteForce.Services;

namespace PasswordResetBruteForce
{
    public partial class Form1 : Form
    {
        private string currentPassword = "";
        private string currentHash = "";

        private AttackManager attackManager = new AttackManager();

        private long singleThreadTime = 0;
        private long multiThreadTime = 0;

        public Form1()
        {
            InitializeComponent();

            attackManager.OnAttempt = attempt =>
            {
                Invoke(() =>
                {
                    lblCurrentAttempt.Text = attempt;
                });
            };

            attackManager.OnProgress = progress =>
            {
                Invoke(() =>
                {
                    progressBar1.Value = progress;
                });
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PasswordGenerator generator = new PasswordGenerator();
            PasswordHasher hasher = new PasswordHasher();

            currentPassword = generator.GeneratePassword();

            currentHash = hasher.HashPassword(currentPassword);

            lblPassword.Text = currentPassword;
            lblHash.Text = currentHash;
        }

        private async void btnStartAttack_Click(object sender, EventArgs e)
        {
            lblFoundPassword.Text = "Searching...";

            string? foundPassword = await Task.Run(() =>
            {
                return attackManager.StartAttack(currentHash);
            });

            lblFoundPassword.Text = foundPassword;

            TimeSpan elapsed =
                TimeSpan.FromMilliseconds(attackManager.ElapsedMilliseconds);

            lblElapsedTime.Text =
                elapsed.ToString(@"mm\:ss\.fff");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            attackManager.StopAttack();
        }

        private async void button1_Click_2(object sender, EventArgs e)
        {
            AttackManagerSingle single = new AttackManagerSingle();

            string? result = await Task.Run(() =>
            {
                return single.StartAttack(currentHash);
            });

            TimeSpan elapsed =
                TimeSpan.FromMilliseconds(single.ElapsedMilliseconds);

            singleThreadTime = single.ElapsedMilliseconds;

            lblSingleResult.Text =
                "Single Thread: " +
                elapsed.ToString(@"mm\:ss\.fff");

            UpdateWinner();
        }

        private async void btnMultiThreadTest_Click(object sender, EventArgs e)
        {
            AttackManager multi = new AttackManager();

            string? result = await Task.Run(() =>
            {
                return multi.StartAttack(currentHash);
            });

            TimeSpan elapsed =
                TimeSpan.FromMilliseconds(multi.ElapsedMilliseconds);

            multiThreadTime = multi.ElapsedMilliseconds;

            lblMultiResult.Text =
                "Multi Thread: " +
                elapsed.ToString(@"mm\:ss\.fff");

            UpdateWinner();
        }

        private void UpdateWinner()
        {
            if (singleThreadTime == 0 || multiThreadTime == 0)
                return;

            if (singleThreadTime < multiThreadTime)
            {
                lblWinner.Text = "Winner: Single Thread";
            }
            else if (multiThreadTime < singleThreadTime)
            {
                lblWinner.Text = "Winner: Multi Thread";
            }
            else
            {
                lblWinner.Text = "Winner: Tie";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}