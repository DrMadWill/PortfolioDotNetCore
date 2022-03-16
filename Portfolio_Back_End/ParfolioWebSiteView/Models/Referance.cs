using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class Referance
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        public string Title { get; set; }

        [Required]
        [MaxLength(150)]
        public string Image { get; set; }

        public User User { get; set; }
        public string UserId { get; set; }

    }
}
