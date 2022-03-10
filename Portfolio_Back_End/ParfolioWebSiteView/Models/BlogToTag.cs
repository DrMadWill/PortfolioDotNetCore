using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class BlogToTag
    {
        public Blog Blog { get; set; }
        public int BlogId { get; set; }

        public Tag Tag { get; set; }
        public int TagId { get; set; }


    }
}
