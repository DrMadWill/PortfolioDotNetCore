using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class Home
    {
        public int Id { get; set; }

        [MaxLength(250)]
        [Required]
        public string HomeSlogan { get; set; }

        [MaxLength(150)]
        [Required]
        public string Image { get; set; }

        public bool IsShow { get; set; }

    }
}
