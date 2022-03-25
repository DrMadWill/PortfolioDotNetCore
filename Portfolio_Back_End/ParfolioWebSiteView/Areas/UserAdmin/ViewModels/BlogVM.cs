using Microsoft.AspNetCore.Http;
using ParfolioWebSiteView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Areas.UserAdmin.ViewModels
{
    public class BlogVM
    {
        public int Id { get; set; }
        public List<BlogCategory> CategoriesVM { get; set; }
        public List<Tag> Tags { get; set; }
        public Blog Blog { get; set; }
        public List<int> TagIds { get; set; }
        public IFormFile Photo { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
