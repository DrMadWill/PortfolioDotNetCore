using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class ContactOnline
    {
        public virtual int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(150)]
        [Required]
        public string Url { get; set; }

        [MaxLength(200)]
        [Required]
        public string Icon { get; set; }
        public virtual Contact Contact { get; set; }
        [Required]
        public virtual string ContactId { get; set; }

    }
}
