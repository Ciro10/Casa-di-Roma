using Casa_di_Roma.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Casa_di_Roma.Models
{
      

    public class Cart
{
                public int ID { get; set; }

                public IList<MenuItem> menuitems;

                public Cart() { }

                public   void Cartadditem(MenuItem menuItem)
                {
                       menuitems.Add(menuItem);
                }

                private Casa_di_RomaDbContext context;

                public Cart(Casa_di_RomaDbContext dbContext)
                {
                        context = dbContext;
                }

                public void Cartadditem(int id)
                {
                        MenuItem YourItem = context.MenuItems.Single(c => c.ID == id);
                        context.Add(YourItem);
                        context.SaveChanges();

                }
                

}
}
