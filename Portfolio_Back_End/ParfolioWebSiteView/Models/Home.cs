using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class Home
    {
        [ForeignKey("User")]
        public string Id { get; set; }
        public User User { get; set; }

        [MaxLength(350,ErrorMessage ="Maximum Length is 350")]
        [MinLength(3,ErrorMessage = "Maximum Length is 350")]
        [Required(ErrorMessage = "Slogan is Required")]
        public string HomeSlogan { get; set; }

        [MaxLength(3000, ErrorMessage = "Maximum Length is 3000")]
        [MinLength(3, ErrorMessage = "Maximum Length is 350")]
        public string Skills { get; set; }

        [MaxLength(150)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Potho { get; set; }

    }
}
