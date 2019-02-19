using Casa_di_Roma.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Casa_di_Roma.Models
{
        public class MenuItem
        {
                public string Name { get; set; }
                public string Description { get; set; }
                public double Price { get; set; }
                public int ID { get; set; }
                public int Quantity { get; set; }

                public MenuItem(string name, string description, double price)
                {
                        this.Name = name;
                        this.Description = description;
                        this.Price = price;
                        //item.Price.ToString("C")
                }

               

        }

        
}
