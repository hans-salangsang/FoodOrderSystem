namespace FoodOrderSystem
{
    partial class WelcomeForm
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
            tableLayoutPanel2 = new TableLayoutPanel();
            usernameTextBox = new TextBox();
            usernameTextBoxLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            passwordTextBox = new TextBox();
            passwordTextBoxLabel = new Label();
            showPasswordCheckBox = new CheckBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            takeOrderButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 1, 4);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.27711F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.72289F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 119F));
            tableLayoutPanel1.Size = new Size(1342, 744);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.69173F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.30827F));
            tableLayoutPanel2.Controls.Add(usernameTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(usernameTextBoxLabel, 0, 0);
            tableLayoutPanel2.Location = new Point(338, 501);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(665, 38);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.Left;
            usernameTextBox.Font = new Font("Poppins", 12F);
            usernameTextBox.Location = new Point(247, 3);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(258, 31);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // usernameTextBoxLabel
            // 
            usernameTextBoxLabel.Anchor = AnchorStyles.Right;
            usernameTextBoxLabel.AutoSize = true;
            usernameTextBoxLabel.Font = new Font("Poppins SemiBold", 12F);
            usernameTextBoxLabel.Location = new Point(144, 5);
            usernameTextBoxLabel.Name = "usernameTextBoxLabel";
            usernameTextBoxLabel.Size = new Size(97, 28);
            usernameTextBoxLabel.TabIndex = 0;
            usernameTextBoxLabel.Text = "Username";
            usernameTextBoxLabel.Click += usernameTextBoxLabel_Click;
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
            tableLayoutPanel3.Location = new Point(338, 545);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel3.Size = new Size(665, 76);
            tableLayoutPanel3.TabIndex = 2;
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
            showPasswordCheckBox.Location = new Point(247, 47);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(108, 19);
            showPasswordCheckBox.TabIndex = 3;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel4.Location = new Point(338, 99);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.363636F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 88.63636F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(665, 396);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 27F);
            label1.Location = new Point(211, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 45);
            label1.TabIndex = 0;
            label1.Text = "Welcome to";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.snackdashLogo;
            pictureBox1.Location = new Point(3, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(659, 188);
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
            tableLayoutPanel6.Controls.Add(takeOrderButton, 0, 0);
            tableLayoutPanel6.Location = new Point(338, 627);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(665, 62);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // takeOrderButton
            // 
            takeOrderButton.Anchor = AnchorStyles.None;
            takeOrderButton.BackColor = Color.FromArgb(255, 202, 64);
            takeOrderButton.Cursor = Cursors.Hand;
            takeOrderButton.Font = new Font("Poppins SemiBold", 12F);
            takeOrderButton.Location = new Point(243, 7);
            takeOrderButton.Name = "takeOrderButton";
            takeOrderButton.Size = new Size(179, 48);
            takeOrderButton.TabIndex = 0;
            takeOrderButton.Text = "Take Orders";
            takeOrderButton.UseVisualStyleBackColor = false;
            takeOrderButton.Click += takeOrderButton_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1366, 768);
            Controls.Add(tableLayoutPanel1);
            Name = "WelcomeForm";
            Text = "Welcome to SnackDash POS!";
            FormClosed += Welcome_FormClosed;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
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
        private Button takeOrderButton;
        private PictureBox pictureBox1;
        private CheckBox showPasswordCheckBox;
    }
}
