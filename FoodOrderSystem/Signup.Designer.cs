namespace FoodOrderSystem
{
    partial class SignupForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label4 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            loginButton = new Button();
            signupButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            passwordTextBox = new TextBox();
            passwordTextBoxLabel = new Label();
            showPasswordCheckBox = new CheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            usernameTextBox = new TextBox();
            usernameTextBoxLabel = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            lastNameTextBox = new TextBox();
            label2 = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            firstNameTextBox = new TextBox();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 1, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.1803722F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.8196259F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 155F));
            tableLayoutPanel1.Size = new Size(1342, 744);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label4, 0, 2);
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel4.Location = new Point(338, 64);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.363636F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 88.63636F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(665, 310);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 18F);
            label4.Location = new Point(272, 252);
            label4.Name = "label4";
            label4.Size = new Size(121, 42);
            label4.TabIndex = 2;
            label4.Text = "Register:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F);
            label1.Location = new Point(278, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 0;
            label1.Text = "Welcome to";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.snackdashLogo;
            pictureBox1.Location = new Point(105, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(454, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(loginButton, 0, 1);
            tableLayoutPanel6.Controls.Add(signupButton, 0, 0);
            tableLayoutPanel6.Location = new Point(338, 591);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel6.Size = new Size(665, 117);
            tableLayoutPanel6.TabIndex = 5;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.None;
            loginButton.BackColor = Color.White;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderColor = Color.FromArgb(255, 202, 64);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Poppins SemiBold", 12F);
            loginButton.ForeColor = Color.Black;
            loginButton.Location = new Point(243, 64);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(179, 48);
            loginButton.TabIndex = 1;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // signupButton
            // 
            signupButton.Anchor = AnchorStyles.None;
            signupButton.BackColor = Color.FromArgb(255, 202, 64);
            signupButton.Cursor = Cursors.Hand;
            signupButton.FlatAppearance.BorderSize = 0;
            signupButton.FlatStyle = FlatStyle.Flat;
            signupButton.Font = new Font("Poppins SemiBold", 12F);
            signupButton.Location = new Point(243, 6);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(179, 48);
            signupButton.TabIndex = 0;
            signupButton.Text = "Sign up";
            signupButton.UseVisualStyleBackColor = false;
            signupButton.Click += signupButton_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.69173F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.30827F));
            tableLayoutPanel3.Controls.Add(passwordTextBox, 1, 0);
            tableLayoutPanel3.Controls.Add(passwordTextBoxLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(showPasswordCheckBox, 1, 1);
            tableLayoutPanel3.Location = new Point(338, 509);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.Size = new Size(665, 76);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Left;
            passwordTextBox.Font = new Font("Poppins", 12F);
            passwordTextBox.Location = new Point(247, 3);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(258, 31);
            passwordTextBox.TabIndex = 1;
            // 
            // passwordTextBoxLabel
            // 
            passwordTextBoxLabel.Anchor = AnchorStyles.Right;
            passwordTextBoxLabel.AutoSize = true;
            passwordTextBoxLabel.Font = new Font("Poppins SemiBold", 12F);
            passwordTextBoxLabel.Location = new Point(149, 4);
            passwordTextBoxLabel.Name = "passwordTextBoxLabel";
            passwordTextBoxLabel.Size = new Size(92, 28);
            passwordTextBoxLabel.TabIndex = 0;
            passwordTextBoxLabel.Text = "Password";
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.Anchor = AnchorStyles.Left;
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Cursor = Cursors.Hand;
            showPasswordCheckBox.Location = new Point(247, 46);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(108, 19);
            showPasswordCheckBox.TabIndex = 3;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.69173F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.30827F));
            tableLayoutPanel2.Controls.Add(usernameTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(usernameTextBoxLabel, 0, 0);
            tableLayoutPanel2.Location = new Point(338, 466);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(665, 37);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.Left;
            usernameTextBox.Font = new Font("Poppins", 12F);
            usernameTextBox.Location = new Point(247, 3);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(258, 31);
            usernameTextBox.TabIndex = 0;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // usernameTextBoxLabel
            // 
            usernameTextBoxLabel.Anchor = AnchorStyles.Right;
            usernameTextBoxLabel.AutoSize = true;
            usernameTextBoxLabel.Font = new Font("Poppins SemiBold", 12F);
            usernameTextBoxLabel.Location = new Point(144, 4);
            usernameTextBoxLabel.Name = "usernameTextBoxLabel";
            usernameTextBoxLabel.Size = new Size(97, 28);
            usernameTextBoxLabel.TabIndex = 0;
            usernameTextBoxLabel.Text = "Username";
            usernameTextBoxLabel.Click += usernameTextBoxLabel_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.69173F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.30827F));
            tableLayoutPanel5.Controls.Add(lastNameTextBox, 1, 0);
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Location = new Point(338, 423);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(665, 37);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Anchor = AnchorStyles.Left;
            lastNameTextBox.Font = new Font("Poppins", 12F);
            lastNameTextBox.Location = new Point(247, 3);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(258, 31);
            lastNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Poppins SemiBold", 12F);
            label2.Location = new Point(142, 4);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 0;
            label2.Text = "Last Name";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.69173F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.30827F));
            tableLayoutPanel7.Controls.Add(firstNameTextBox, 1, 0);
            tableLayoutPanel7.Controls.Add(label3, 0, 0);
            tableLayoutPanel7.Location = new Point(338, 380);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(665, 37);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Anchor = AnchorStyles.Left;
            firstNameTextBox.Font = new Font("Poppins", 12F);
            firstNameTextBox.Location = new Point(247, 3);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(258, 31);
            firstNameTextBox.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Poppins SemiBold", 12F);
            label3.Location = new Point(142, 4);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 0;
            label3.Text = "First Name";
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1366, 768);
            Controls.Add(tableLayoutPanel1);
            Name = "SignupForm";
            Text = "Sign Up to SnackDash";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label usernameTextBoxLabel;
        private TextBox usernameTextBox;
        private Label passwordTextBoxLabel;
        private TextBox passwordTextBox;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel6;
        private Button signupButton;
        private PictureBox pictureBox1;
        private CheckBox showPasswordCheckBox;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox lastNameTextBox;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox firstNameTextBox;
        private Label label3;
        private Button loginButton;
        private Label label4;
    }
}
