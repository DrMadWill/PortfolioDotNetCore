using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class BlogCategory
    {
        public virtual int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        public virtual List<Blog> Blogs { get; set; }
    }
}
