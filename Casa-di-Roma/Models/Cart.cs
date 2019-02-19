using Casa_di_Roma.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Casa_di_Roma.Models
{
      

    public class Cart
{
                
                public int ID { get; set; }

                public string Basket { get; set; }

                public List<MenuItem> menuitems { get; set; }

                static private List<MenuItem> Menuitems = new List<MenuItem>();

                static public double Total { get; set; }

                
                public static List<MenuItem> GetAll()
                {
                        
                        return Menuitems;
                }

                public static MenuItem GetById(int menuitemId)
                {
                        return Menuitems.Single(x => x.ID == menuitemId);
                }

                public static void Add(MenuItem newMenuItem)
                {

                        newMenuItem.Quantity++;
                        Menuitems.Add(newMenuItem);

                                            
                        Total += newMenuItem.Price;
                               
                }

                public static bool Remove(int menuitemId)
                {
                        
                        return Menuitems.Remove(GetById(menuitemId));
                }

                

}
}
