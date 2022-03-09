using ParfolioWebSiteView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.ViewModels
{
    public class IndexVM
    {
        public Home Home { get; set; }
        public Achievements Achievement { get; set; }
        public About About { get; set; }
        public List<Service> Services { get; set; }
        public List<Referance> Referances { get; set; }
        public List<Skill> Skills { get; set; }
        public List<SkillCode> SkillCode { get; set; }
        public Contact Contact { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<ContactOnline> ContactOnlines { get; set; }
        public List<Blog> Blogs { get; set; }




    }
}
