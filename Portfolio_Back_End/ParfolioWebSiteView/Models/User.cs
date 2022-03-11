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

        [MaxLength(100)]
        [MinLength(1)]
        public string Image { get; set; }
        [MaxLength(100)]
        [MinLength(3)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(100)]
        [MinLength(3)]
        [Required]
        public string LastName { get; set; }

        public bool Gender { get; set; }

    }
}
