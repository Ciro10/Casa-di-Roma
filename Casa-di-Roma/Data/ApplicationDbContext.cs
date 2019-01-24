using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Casa_di_Roma.Data
{
        public class ApplicationDbContext : IdentityDbContext
        {
                public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                    : base(options)
                {
                }
        }
}
