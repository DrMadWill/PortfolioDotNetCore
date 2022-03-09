using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [MaxLength(75)]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public List<ContactOnline> ContactOnlines { get; set; }
        public bool IsShow { get; set; }

    }
}
