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
        public virtual About About { get; set; }
        public virtual Home Home { get; set; }
        public virtual Contact Contact { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        public virtual IList<Blog> Blogs { get; set; }
        public virtual IList<Achievements> Achievements { get; set; }
        public virtual IList<Referance> Referances { get; set; }
        public virtual IList<Service> Services { get; set; }
        public virtual IList<Portfolio> Portfolios { get; set; }
        public virtual IList<Commet> Commets { get; set; }
        public virtual IList<MessengeUser> MessengeUsers { get; set; }
    }
}
