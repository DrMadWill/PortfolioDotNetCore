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
        public  virtual string Id { get; set; }
        public virtual User User { get; set; }

        [MaxLength(75,ErrorMessage ="Max Length 75 ")]
        [Phone(ErrorMessage ="Plase Write Phone Number Format")]
        public string PhoneNumber { get; set; }
        [MaxLength(150,ErrorMessage = "Max Length 150 ")]
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(300, ErrorMessage = "Max Length 150.")]
        [Required(ErrorMessage = "Location Is Required.")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Description Is Required.")]
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        public virtual List<ContactOnline> ContactOnlines { get; set; }
        
    }
}
