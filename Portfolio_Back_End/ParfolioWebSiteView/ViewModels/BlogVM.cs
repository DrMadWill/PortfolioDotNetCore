using ParfolioWebSiteView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.ViewModels
{
    public class BlogVM
    {
        public Blog Blog { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Commet> Commets { get; set; }
        public List<Tag> Tags { get; set; }

        // Comment Section

        public int CommentCount { get; set; }

    }
}
