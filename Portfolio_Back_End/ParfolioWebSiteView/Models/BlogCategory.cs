using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class BlogCategory
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
