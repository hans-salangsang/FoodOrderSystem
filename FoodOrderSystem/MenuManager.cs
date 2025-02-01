using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
                    "French Fries1",
                    50m,
                    "Appetizer",
                    LoadImageFromResource("FoodOrderSystem.Resources.Burger.png"),
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
                    "Onion Rings2",
                    30m,
                    "Appetizer",
                    LoadImageFromResource("FoodOrderSystem.Resources.Burger.png"),
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
                    "Chicken Wings3",
                    120m,
                    "Appetizer",
                    LoadImageFromResource("FoodOrderSystem.Resources.Burger.png"),
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
                    "French Fries4",
                    50m,
                    "Appetizer",
                    LoadImageFromResource("FoodOrderSystem.Resources.Burger.png"),
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
                    "Onion Rings5",
                    30m,
                    "Appetizer",
                    LoadImageFromResource("FoodOrderSystem.Resources.Burger.png"),
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
                    "Chicken Wings6",
                    120m,
                    "Appetizer",
                    LoadImageFromResource("FoodOrderSystem.Resources.Burger.png"),
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
                    "French Fries7",
                    50m,
                    "Appetizer",
                    LoadImageFromResource("FoodOrderSystem.Resources.Burger.png"),
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
                    "Onion Rings8",
                    30m,
                    "Appetizer",
                    LoadImageFromResource("FoodOrderSystem.Resources.Burger.png"),
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
                    "Chicken Wings9",
                    120m,
                    "Appetizer",
                    LoadImageFromResource("FoodOrderSystem.Resources.Burger.png"),
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
                    "French Fries10",
                    50m,
                    "Appetizer",
                    LoadImageFromResource("FoodOrderSystem.Resources.Burger.png"),
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
                    "Onion Rings11",
                    30m,
                    "Appetizer",
                    LoadImageFromResource("FoodOrderSystem.Resources.Burger.png"),
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
                    "Chicken Wings12",
                    120m,
                    "Appetizer",
                    LoadImageFromResource("FoodOrderSystem.Resources.Burger.png"),
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
                    "Chicken Wings13",
                    120m,
                    "Appetizer",
                    LoadImageFromResource("FoodOrderSystem.Resources.Burger.png"),
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

        // Method to load the image from embedded resources
        private Image LoadImageFromResource(string resourceName)
        {
            // Get the current assembly
            var assembly = Assembly.GetExecutingAssembly();

            // Load the resource stream from the assembly
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                {
                    // Create and return the image from the stream
                    return Image.FromStream(stream);
                }
                else
                {
                    // Handle the case where the image is not found in the resources
                    throw new FileNotFoundException($"Resource {resourceName} not found.");
                }
            }
        }
    }
}
