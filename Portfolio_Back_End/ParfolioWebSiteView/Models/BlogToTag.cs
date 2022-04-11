using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class BlogToTag
    {
        public virtual Blog Blog { get; set; }
        public virtual int BlogId { get; set; }

        public virtual Tag Tag { get; set; }
        public virtual int TagId { get; set; }


    }
}
