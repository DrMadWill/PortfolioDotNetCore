using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class MessengeUser
    {
        [Key]
        public int Id { get; set; }

        public User User { get; set; }
        public string UserId { get; set; }

        [MaxLength(100)]
        [Required(ErrorMessage = "Subject is required.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Email format is valid")]
        public string Email { get; set; }

        [MaxLength(200)]
        [Required(ErrorMessage = "Subject is required.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Subject is required.")]
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
    }
}
