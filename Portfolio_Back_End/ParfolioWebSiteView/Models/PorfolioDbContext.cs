using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class PorfolioDbContext : DbContext
    {
        public PorfolioDbContext(DbContextOptions<PorfolioDbContext> dbContext) : base(dbContext) { }



        


    }
}
