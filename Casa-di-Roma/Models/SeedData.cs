using Casa_di_Roma.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Casa_di_Roma.Models
{
    public class SeedData
{
                private static Casa_di_RomaDbContext context;

                public SeedData(Casa_di_RomaDbContext dbContext)
                {
                        context = dbContext;

                }

                public static void Initialize(Casa_di_RomaDbContext context)
                {
                        if (context.MenuItems.Any())
                        {
                                return;
                        }
                        else
                        {
                                context.MenuItems.AddRange(new MenuItem("Calamari", " Tender calamari, lightly breaded and fried.Served with marinara sauce and creamy ranch.", 10.80),
                                new MenuItem("Fried Mozzerella", " Golden-fried mozzarella cheese, topped with an alfredo drizzle. Served with marinara sauce.", 6.99),
                                new MenuItem("Stuffed Mushrooms", " Large portabello mushrooms stuffed  with herb breadcrumbs, parmesan, romano and mozzarella cheeses.", 8.50),
                                new MenuItem("House Salad", " Our Famous House Salad ToGo. Toss with our signature Italian dressing.", 8.76),
                                new MenuItem("Dolcini", " 4 Piccoli Dolci 'little dessert treats', layered with cake, mousse, pastry creams and berries.", 10.34),
                                new MenuItem("Zeppoli", " Soft, traditional Italian doughnuts dusted with powdered sugar, served with chocolate sauce for dipping.", 7.99),
                                new MenuItem("Tiramisu", " The classic Italian dessert. A layer of creamy custard set atop espresso-soaked ladyfingers.", 8.99),
                                new MenuItem("Beef bolognese with parppadelle", " Slow-simmered meat sauce with tender braised beef and Italian sausage, tossed with ruffled pappardella pasta and a touch of alfredo - just like Nonna's recipe.", 14.89),
                                new MenuItem("Beef Ravioli", " In this recipe from Emilia-Romagna, a simple filling of beef and Parmigiano-Reggiano cheese is infused with the flavor of the local Barbera.", 9.30),
                                new MenuItem("Lasagna", " Prepared fresh daily with layers of pasta, parmesan, mozzarella, pecorino romano and our homemade meat sauce.", 11.56),
                                new MenuItem("Shrimp alfredo", " Creamy, homemade fettuccine alfredo tossed with sautéed shrimp.", 10.84),
                                new MenuItem("Chicken parmigiana", " Two lightly fried parmesan-breaded chicken breasts are smothered with Olive Garden’s homemade marinara sauce and melted Italian cheeses. We serve our Chicken Parmigiana with a side of spaghetti for dinner. Try this classic pairing of Italian comfort foods that will leave you saying 'yum!'.", 12.80));

                                context.SaveChanges();
                        }
                }
        }
}
