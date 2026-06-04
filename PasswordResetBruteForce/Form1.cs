using PasswordResetBruteForce.Services;
namespace PasswordResetBruteForce
{
    public partial class Form1 : Form
    {
        private string currentPassword = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PasswordGenerator generator = new PasswordGenerator();
            PasswordHasher hasher = new PasswordHasher();

            currentPassword = generator.GeneratePassword();

            string hash = hasher.HashPassword(currentPassword);

            lblPassword.Text = currentPassword;
            lblHash.Text = hash;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
