using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodOrderSystem
{
    public partial class MenuItemCard : UserControl
    {
        public string MenuItemName
        {
            get { return menuItemNameLabel.Text; }
            set { menuItemNameLabel.Text = value; }
        }

        public string MenuItemPrice
        {
            get { return menuItemPriceLabel.Text; }
            set { menuItemPriceLabel.Text = value; }
        }

        public Image MenuItemImage
        {
            get { return menuItemPictureBox.Image; }
            set { menuItemPictureBox.Image = value; }
        }

        public MenuItemCard()
        {
            InitializeComponent();
        }

        private void MenuItemCard_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void menuItemPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
