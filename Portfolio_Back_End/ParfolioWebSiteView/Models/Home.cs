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

        [MaxLength(250)]
        [Required]
        public string HomeSlogan { get; set; }

        [MaxLength(3000)]
        public string Skills { get; set; }

        [MaxLength(150)]
        [Required]
        public string Image { get; set; }

    }
}
