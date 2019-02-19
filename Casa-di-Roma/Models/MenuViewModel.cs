using Casa_di_Roma.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Casa_di_Roma.Models
{
        public class MenuViewModel
        {
                public IList <MenuItem>Appetizers { get; set; }

                public IList<MenuItem> Entrees { get; set; }

                public IList<MenuItem> Desserts { get; set; }

                private static Casa_di_RomaDbContext context;

                public   MenuViewModel(Casa_di_RomaDbContext dbContext)
                {
                        context = dbContext;

                }

                public  void Load(Casa_di_RomaDbContext context)
                {

                        Appetizers = new List<MenuItem>();
                        Appetizers.Add(context.MenuItems.Single(c => c.Name == "Calamari"));
                       Appetizers.Add(context.MenuItems.Single(c => c.Name == "Fried Mozzerella"));
                        Appetizers.Add(context.MenuItems.Single(c => c.Name == "Stuffed Mushrooms"));

                        Entrees= new List<MenuItem>();
                        Entrees.Add(context.MenuItems.Single(c => c.Name == "House Salad"));
                        Entrees.Add(context.MenuItems.Single(c => c.Name == "Beef bolognese with parppadelle"));
                        Entrees.Add(context.MenuItems.Single(c => c.Name == "Beef Ravioli"));
                        Entrees.Add(context.MenuItems.Single(c => c.Name == "Lasagna"));
                        Entrees.Add(context.MenuItems.Single(c => c.Name == "Shrimp alfredo"));
                        Entrees.Add(context.MenuItems.Single(c => c.Name == "Chicken parmigiana"));

                        Desserts = new List<MenuItem>();
                        Desserts.Add(context.MenuItems.Single(c => c.Name == "Dolcini"));
                        Desserts.Add(context.MenuItems.Single(c => c.Name == "Zeppoli"));
                        Desserts.Add(context.MenuItems.Single(c => c.Name == "Tiramisu"));
                        
                }

                public void special(Casa_di_RomaDbContext context)
                {
                        Appetizers = new List<MenuItem>();
                        Entrees = new List<MenuItem>();
                        Desserts = new List<MenuItem>();
                        Appetizers.Add(context.MenuItems.Single(c => c.Name == "Calamari"));
                        Entrees.Add(context.MenuItems.Single(c => c.Name == "Chicken parmigiana"));
                        Desserts.Add(context.MenuItems.Single(c => c.Name == "Tiramisu"));

                }


                public MenuViewModel() { }

        }
}