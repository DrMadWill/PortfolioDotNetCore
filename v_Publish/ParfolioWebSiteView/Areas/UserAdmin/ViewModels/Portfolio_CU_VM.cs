using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParfolioWebSiteView.Models;

namespace ParfolioWebSiteView.Areas.UserAdmin.ViewModels
{
    public class Portfolio_CU_VM
    {
        public Portfolio Portfolio { get; set; }
        public PortfolioDetail PortfolioDetail { get; set; }
        public List<PortfolioCategory> PortfolioCategories { get; set; }
    }
}
