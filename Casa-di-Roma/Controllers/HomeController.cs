using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Casa_di_Roma.Models;
using Casa_di_Roma.Data;

namespace Casa_di_Roma.Controllers
{
        public class HomeController : Controller
        {
                private Casa_di_RomaDbContext context;

                public HomeController(Casa_di_RomaDbContext dbContext)
                {
                        context = dbContext;
                        //  MenuItem.SeedData(context);
                        SeedData.Initialize(context);
                }

              

                public IActionResult Index()
                {
                        MenuViewModel homespecial = new MenuViewModel(context);
                        homespecial.special(context);

                        // MenuItem special = context.MenuItems.Single(c => c.Name == "Chicken parmigiana");

                        return View(homespecial);
                }

                public IActionResult MainMenu()
                {
                        MenuViewModel MainMenu = new MenuViewModel(context);
                        MainMenu.Load(context);
                        ViewBag.src = "@";

                        return View(MainMenu);
                }

                

         }
}
