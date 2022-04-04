using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class User: IdentityUser
    {
        [MaxLength(100,ErrorMessage ="So Large Image Name")]
        [MinLength(1, ErrorMessage = "So Small Image Name")]
        public string Image { get; set; }
        [MaxLength(100, ErrorMessage = "So Large FirstName")]
        [MinLength(3, ErrorMessage = "So Small FirstName")]
        [Required(ErrorMessage = "FirstName Required")]
        public string FirstName { get; set; }

        [MaxLength(100, ErrorMessage = "So Large LastName")]
        [MinLength(3, ErrorMessage = "So Small LastName")]
        [Required(ErrorMessage = "LastName Required")]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName { get { return FirstName + " " + LastName; } }
        public bool Gender { get; set; }
        public About About { get; set; }
        public Home Home { get; set; }
        public Contact Contact { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        public IList<Blog> Blogs { get; set; }
        public IList<Achievements> Achievements { get; set; }
        public IList<Referance> Referances { get; set; }
        public IList<Service> Services { get; set; }
        public IList<Portfolio> Portfolios { get; set; }
        public IList<Commet> Commets { get; set; }
        public IList<MessengeUser> MessengeUsers { get; set; }
        public IList<Seal> Seals { get; set; }
    }
}
