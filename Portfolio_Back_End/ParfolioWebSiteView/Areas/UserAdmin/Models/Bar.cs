using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Areas.UserAdmin.Models
{
    public class Bar
    {
        public int Id { get; set; }

        public string Icon { get; set; }

        public string Name { get; set; }

        public List<BarChild> BarChildren { get; set; }

    }
}
