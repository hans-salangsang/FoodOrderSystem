using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderSystem
{
    internal class MenuManager
    {
        private List<MenuItem> menu;

        public MenuManager()
        {
            menu = new List<MenuItem>()
            {
                new MenuItem(
                    Guid.NewGuid(),
                    "French Fries",
                    50m,
                    "Appetizer",
                    new List<MenuItemVariation>
                    {
                        new MenuItemVariation(Guid.NewGuid(),"Regular", 0),
                        new MenuItemVariation(Guid.NewGuid(),"Barbeque", 5),
                        new MenuItemVariation(Guid.NewGuid(),"Cheese", 5),
                        new MenuItemVariation(Guid.NewGuid(),"Sour cream", 5),
                    }
                ),

                new MenuItem(
                    Guid.NewGuid(),
                    "Onion Rings",
                    30m,
                    "Appetizer",
                    new List<MenuItemVariation>
                    {
                        new MenuItemVariation(Guid.NewGuid(),"Regular", 0),
                        new MenuItemVariation(Guid.NewGuid(),"Barbeque", 5),
                        new MenuItemVariation(Guid.NewGuid(),"Cheese", 5),
                        new MenuItemVariation(Guid.NewGuid(),"Sour cream", 5),
                    }
                ),

                new MenuItem(
                    Guid.NewGuid(),
                    "Chicken Wings",
                    120m,
                    "Appetizer",
                    new List<MenuItemVariation>
                    {
                        new MenuItemVariation(Guid.NewGuid(),"Regular", 0),
                        new MenuItemVariation(Guid.NewGuid(),"Barbeque", 5),
                        new MenuItemVariation(Guid.NewGuid(),"Cheese", 5),
                        new MenuItemVariation(Guid.NewGuid(),"Sour cream", 5),
                    }
                ),
            };
        }

        public void AddMenuItem(MenuItem item)
        {
            menu.Add(item);
        }

        public void RemoveMenuItem(string name)
        {
            var itemToRemove = menu.FirstOrDefault(item => item.Name == name);

            if (itemToRemove != null)
            {
                menu.Remove(itemToRemove);
            }
        }

        public List<MenuItem> GetMenuItems()
        {
            return menu;
        }
    }
}
