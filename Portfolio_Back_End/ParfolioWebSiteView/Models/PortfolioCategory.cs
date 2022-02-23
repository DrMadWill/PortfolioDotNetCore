using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class PortfolioCategory
    {
        public int Id { get; set; }
        public string  Name { get; set; }

        public List<Portfolio> Portfolios { get; set; }

    }
}
