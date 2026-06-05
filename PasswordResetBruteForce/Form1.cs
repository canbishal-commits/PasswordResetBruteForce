using PasswordResetBruteForce.Services;
namespace PasswordResetBruteForce
{
    public partial class Form1 : Form
    {
        private string currentPassword = "";
        private string currentHash = "";
        public Form1()
        {
            InitializeComponent();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStartAttack_Click(object sender, EventArgs e)
        {
            AttackManager attackManager = new AttackManager();

            string? foundPassword = attackManager.StartAttack(currentHash);

            lblFoundPassword.Text = foundPassword;
            TimeSpan elapsed = TimeSpan.FromMilliseconds(attackManager.ElapsedMilliseconds);

            lblElapsedTime.Text =
                $"{elapsed.Minutes} min {elapsed.Seconds} sec {elapsed.Milliseconds} ms";
        }
    }
}
