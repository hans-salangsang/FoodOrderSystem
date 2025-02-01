using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderSystem
{
    internal class MenuItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public Image Image { get; set; }
        public List<MenuItemVariation> Variations { get; set; }

        public MenuItem(Guid id, string name, decimal price, string category, Image image, List<MenuItemVariation> variations)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Category = category;
            this.Image = image;
            this.Variations = variations ?? new List<MenuItemVariation>();
        }
    }
}
