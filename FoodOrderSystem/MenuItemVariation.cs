using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderSystem
{
    internal class MenuItemVariation
    {
        public Guid Id { get; set; }
        public string Variation { get; set; }
        public decimal AdditionalPrice { get; set; }

        public MenuItemVariation(Guid id, string variation, decimal additionalPrice)
        {
            this.Id = id;
            this.Variation = variation;
            this.AdditionalPrice = additionalPrice;
        }
    }
}
