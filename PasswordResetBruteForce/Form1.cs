using System.Threading.Tasks;
using PasswordResetBruteForce.Services;
namespace PasswordResetBruteForce
{
    public partial class Form1 : Form
    {
        private string currentPassword = "";
        private string currentHash = "";
        private AttackManager attackManager = new AttackManager();
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

        private async void btnStartAttack_Click(object sender, EventArgs e)
        {
            lblFoundPassword.Text = "Searching...";

            string? foundPassword = await Task.Run(() =>
            {
                return attackManager.StartAttack(currentHash);
            });

            lblFoundPassword.Text = foundPassword;

            TimeSpan elapsed = TimeSpan.FromMilliseconds(attackManager.ElapsedMilliseconds);

            lblElapsedTime.Text = elapsed.ToString(@"mm\:ss\.fff");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            attackManager.StopAttack();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
