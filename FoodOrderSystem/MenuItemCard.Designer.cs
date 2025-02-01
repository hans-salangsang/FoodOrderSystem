namespace FoodOrderSystem
{
    partial class MenuItemCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cardTableLayoutPanel = new TableLayoutPanel();
            menuItemPictureBox = new PictureBox();
            menuItemNameLabel = new Label();
            menuItemPriceLabel = new Label();
            menuItemCardPanel = new Panel();
            cardTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuItemPictureBox).BeginInit();
            menuItemCardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // cardTableLayoutPanel
            // 
            cardTableLayoutPanel.BackColor = SystemColors.ButtonHighlight;
            cardTableLayoutPanel.ColumnCount = 1;
            cardTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            cardTableLayoutPanel.Controls.Add(menuItemPictureBox, 0, 0);
            cardTableLayoutPanel.Controls.Add(menuItemNameLabel, 0, 1);
            cardTableLayoutPanel.Controls.Add(menuItemPriceLabel, 0, 2);
            cardTableLayoutPanel.Dock = DockStyle.Fill;
            cardTableLayoutPanel.Location = new Point(0, 0);
            cardTableLayoutPanel.Name = "cardTableLayoutPanel";
            cardTableLayoutPanel.RowCount = 3;
            cardTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 82.35294F));
            cardTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.6470585F));
            cardTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            cardTableLayoutPanel.Size = new Size(168, 203);
            cardTableLayoutPanel.TabIndex = 0;
            cardTableLayoutPanel.Paint += tableLayoutPanel1_Paint_1;
            // 
            // menuItemPictureBox
            // 
            menuItemPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuItemPictureBox.Location = new Point(3, 30);
            menuItemPictureBox.Margin = new Padding(3, 30, 3, 10);
            menuItemPictureBox.Name = "menuItemPictureBox";
            menuItemPictureBox.Size = new Size(162, 86);
            menuItemPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            menuItemPictureBox.TabIndex = 0;
            menuItemPictureBox.TabStop = false;
            menuItemPictureBox.Click += menuItemPictureBox_Click;
            // 
            // menuItemNameLabel
            // 
            menuItemNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            menuItemNameLabel.AutoSize = true;
            menuItemNameLabel.Font = new Font("Poppins SemiBold", 12F);
            menuItemNameLabel.Location = new Point(3, 126);
            menuItemNameLabel.Name = "menuItemNameLabel";
            menuItemNameLabel.Size = new Size(162, 27);
            menuItemNameLabel.TabIndex = 1;
            menuItemNameLabel.Text = "label1";
            menuItemNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuItemPriceLabel
            // 
            menuItemPriceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuItemPriceLabel.AutoSize = true;
            menuItemPriceLabel.Font = new Font("Poppins SemiBold", 12F);
            menuItemPriceLabel.ForeColor = SystemColors.ControlDark;
            menuItemPriceLabel.Location = new Point(3, 153);
            menuItemPriceLabel.Name = "menuItemPriceLabel";
            menuItemPriceLabel.Size = new Size(162, 28);
            menuItemPriceLabel.TabIndex = 2;
            menuItemPriceLabel.Text = "label2";
            menuItemPriceLabel.TextAlign = ContentAlignment.MiddleCenter;
            menuItemPriceLabel.Click += label2_Click;
            // 
            // menuItemCardPanel
            // 
            menuItemCardPanel.BorderStyle = BorderStyle.FixedSingle;
            menuItemCardPanel.Controls.Add(cardTableLayoutPanel);
            menuItemCardPanel.Dock = DockStyle.Fill;
            menuItemCardPanel.Location = new Point(0, 0);
            menuItemCardPanel.Name = "menuItemCardPanel";
            menuItemCardPanel.Size = new Size(170, 205);
            menuItemCardPanel.TabIndex = 1;
            // 
            // MenuItemCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menuItemCardPanel);
            Name = "MenuItemCard";
            Size = new Size(170, 205);
            Load += MenuItemCard_Load;
            cardTableLayoutPanel.ResumeLayout(false);
            cardTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuItemPictureBox).EndInit();
            menuItemCardPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel cardTableLayoutPanel;
        private PictureBox menuItemPictureBox;
        private Label menuItemNameLabel;
        private Label menuItemPriceLabel;
        private Panel menuItemCardPanel;
    }
}
