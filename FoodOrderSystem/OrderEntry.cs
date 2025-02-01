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
    public partial class OrderEntryForm : Form
    {
        private MenuManager menuManager;
        public OrderEntryForm()
        {
            InitializeComponent();
            this.menuManager = new MenuManager();

            GenerateMenu(menuManager.GetMenuItems());
        }

        private void GenerateMenu(List<MenuItem> menuItems)
        {
            int rowIndex = 0;
            int columnIndex = 0;

            menuItemTableLayoutPanel.RowStyles.Clear();

            foreach (MenuItem item in menuItems)
            {
                // Create a new instance of MenuItemCard
                MenuItemCard menuCard = new MenuItemCard();

                // Set the properties for the card
                menuCard.MenuItemName = item.Name;
                menuCard.MenuItemPrice = item.Price.ToString("C2");
                menuCard.MenuItemImage = item.Image;

                // Set Anchor to None, which allows it to center inside the cell
                menuCard.Anchor = AnchorStyles.None;

                // Add the MenuItemCard to the TableLayoutPanel
                menuItemTableLayoutPanel.Controls.Add(menuCard, columnIndex, rowIndex);

                // Increment column index
                columnIndex++;

                // After 3 columns, reset columnIndex and increment rowIndex
                if (columnIndex == 3)
                {
                    columnIndex = 0;
                    rowIndex++;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
