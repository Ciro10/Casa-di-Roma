using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Casa_di_Roma.Data;
using Casa_di_Roma.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casa_di_Roma.Controllers
{
    public class CartController : Controller
    {

                private Casa_di_RomaDbContext context;

                public CartController(Casa_di_RomaDbContext dbContext)
                {
                        context = dbContext;
                }



                public IActionResult Index()
                {
                        Cart MyCart = new Cart
                        {
                                menuitems = Cart.GetAll()

                        };


                        return View(MyCart);
                }

                [HttpPost]
                public IActionResult Index(int newItem)
                {
                        Cart MyCart = new Cart
                        {
                                menuitems = Cart.GetAll()

                        };

                        MenuItem NewItem = context.MenuItems.Single(c => c.ID == newItem);
                      
                        foreach (MenuItem plate in MyCart.menuitems)
                        {
                                if (plate.ID == NewItem.ID)
                                {
                                        plate.Quantity++;
                                        Cart.Total += NewItem.Price;
                                        NewItem.Price += NewItem.Price;


                                        return View(MyCart);
                                }

                        }

                        Cart.Add(NewItem);

                        return View(MyCart);
                }

                
        }
}