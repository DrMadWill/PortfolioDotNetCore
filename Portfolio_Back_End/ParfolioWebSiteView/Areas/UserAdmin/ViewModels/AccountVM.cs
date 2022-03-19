using ParfolioWebSiteView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Areas.UserAdmin.ViewModels
{
    public class AccountVM
    {
        public Home Home { get; set; }
        public About About { get; set; }
        public Contact Contact { get; set; }
    }
}
