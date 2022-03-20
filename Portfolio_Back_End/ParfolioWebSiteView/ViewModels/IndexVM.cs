using ParfolioWebSiteView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.ViewModels
{
    public class IndexVM
    {
        public User User { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<Blog> Blogs { get; set; }
        public MessengeUser MessengeUser { get; set; }

        public string Error { get; set; }
        public string MessangeSuccess { get; set; }
        public bool IsError { get; set; } = false;
        public bool IsSuccessMessange { get; set; } = false;

    }
}
