using ParfolioWebSiteView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.ViewModels
{
    public class SearchVM
    {
        public List<Blog> Blogs { get; set; }
        public List<Blog> Popliar { get; set; }
        public List<Tag> Tags { get; set; }
        public User User { get; set; }
        public List<User> Users { get; set; }
        public string Type { get; set; }
        public bool isUser { get; set; }

    }
}
