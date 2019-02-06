using System;
using System.Collections.Generic;
using System.Text;
using Casa_di_Roma.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Casa_di_Roma.Data
{
        public class Casa_di_RomaDbContext : IdentityDbContext
        {

                public DbSet<MenuItem> MenuItems { get; set; }

                public DbSet<Cart> Carts { get; set; }

                public Casa_di_RomaDbContext(DbContextOptions<Casa_di_RomaDbContext> options)
                    : base(options)
                {
                }
        }
}
