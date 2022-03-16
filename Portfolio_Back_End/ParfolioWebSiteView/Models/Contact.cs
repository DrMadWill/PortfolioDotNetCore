using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class Contact
    {
        [ForeignKey("User")]
        public string Id { get; set; }
        public User User { get; set; }

        [MaxLength(75)]
        public string PhoneNumber { get; set; }
        [MaxLength(150)]
        public string Email { get; set; }
        [MaxLength(300)]
        public string Location { get; set; }
        public string Description { get; set; }
        public List<ContactOnline> ContactOnlines { get; set; }
        public bool IsShow { get; set; }
    }
}
