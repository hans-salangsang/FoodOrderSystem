namespace FoodOrderSystem
{
    public partial class SignupForm : Form
    {
        private UserManager userManager;
        private WelcomeForm welcomeForm;
        public SignupForm()
        {
            InitializeComponent();
            userManager = new UserManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernameTextBoxLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are mandatory. Please provide all details.");
                return;
            }
            else
            {
                if (this.userManager.GetUserByUsername(username) == null)
                {
                    User newUser = new User(firstName, lastName, username, password);
                    userManager.AddUser(newUser);

                    MessageBox.Show("Sign up successful!\nWelcome to SnackDash!");

                    welcomeForm = new WelcomeForm(userManager);

                    this.Hide();
                    welcomeForm.FormClosed += (s, e) =>
                    {
                        if (welcomeForm.IsClosedByButton)
                        {
                            firstNameTextBox.Clear();
                            lastNameTextBox.Clear();
                            usernameTextBox.Clear();
                            passwordTextBox.Clear();
                            showPasswordCheckBox.Checked = false;
                            this.Show();
                        }
                    };

                    welcomeForm.Show();
                }
                else
                {
                    MessageBox.Show("The username you entered is already taken. Please choose a different username.");
                }
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = showPasswordCheckBox.Checked ? '\0' : '*';
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            welcomeForm = new WelcomeForm(userManager);

            this.Hide();
            welcomeForm.FormClosed += (s, e) =>
            {
                if (welcomeForm.IsClosedByButton)
                {
                    firstNameTextBox.Clear();
                    lastNameTextBox.Clear();
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                    showPasswordCheckBox.Checked = false;
                    this.Show();
                }
            };

            welcomeForm.Show();
        }
    }
}
