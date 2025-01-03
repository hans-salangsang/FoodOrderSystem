namespace FoodOrderSystem
{
    public partial class WelcomeForm : Form
    {
        private UserManager userManager;
        public bool IsClosedByButton { get; set; } = true;
        public WelcomeForm(UserManager userManager)
        {
            InitializeComponent();
            this.userManager = userManager;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernameTextBoxLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void takeOrderButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all the fields to log in.");
                return;
            }
            else
            {
                User currentUser = this.userManager.GetUserByUsername(username);

                if (currentUser != null && currentUser.Username == username && currentUser.Password == password)
                {
                    OrderEntryForm secondForm = new OrderEntryForm();
                    secondForm.Show();
                    this.IsClosedByButton = false;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = showPasswordCheckBox.Checked ? '\0' : '*';
        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
