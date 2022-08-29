using ParfolioWebSiteView.Areas.UserAdmin.Models;
using ParfolioWebSiteView.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParfolioWebSiteView.Areas.UserAdmin.ViewModels
{
    public class SqlSelectVM
    {
        [Required]
        [MinLength(3)]
        public string Code { get; set; }

        public List<TypeM> Data = new List<TypeM>
        {
            new TypeM{ Id = 1, Name = "User" },
            new TypeM{ Id = 2, Name = "DetailImages" },
            new TypeM{ Id = 3, Name = "Abouts" },
            new TypeM{ Id = 4, Name = "Achievements" },
            new TypeM{ Id = 5, Name = "Blogs" },
            new TypeM{ Id = 6, Name = "Contacts" },
            new TypeM{ Id = 7, Name = "ContactOnlines" },
            new TypeM{ Id = 8, Name = "BlogCategories" },
            new TypeM{ Id = 9, Name = "Portfolios" },
            new TypeM{ Id = 10, Name = "PortfolioCategories" },
            new TypeM{ Id = 11, Name = "PortfolioDetails" },
            new TypeM{ Id = 12, Name = "Referances" },
            new TypeM{ Id = 13, Name = "Services" },
            new TypeM{ Id = 14, Name = "SkillCodes" },
            new TypeM{ Id = 15, Name = "Tags" },
            new TypeM{ Id = 16, Name = "BlogToTags" },
            new TypeM{ Id = 18, Name = "Commets" },
            new TypeM{ Id = 17, Name = "BlogDetails" },
            new TypeM{ Id = 19, Name = "Homes" },
            new TypeM{ Id = 20, Name = "MessengeUsers" },
        };

        public int Id { get; set; }

        public string Resault { get; set; }

       
    }
}
