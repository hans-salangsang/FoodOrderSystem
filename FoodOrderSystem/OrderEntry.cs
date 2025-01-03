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

            foreach (MenuItem item in menuItems)
            {
                Label itemLabel = new Label
                {
                    Text = $"{item.Name} - {item.Price}",
                    Width = 500,
                };

                tableLayoutPanel1.Controls.Add(itemLabel, 0, rowIndex++);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
