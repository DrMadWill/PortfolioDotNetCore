using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Areas.UserAdmin.Models
{
    public class BarChild
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Link { get; set; }
        public int BarId { get; set; }

    }
}
