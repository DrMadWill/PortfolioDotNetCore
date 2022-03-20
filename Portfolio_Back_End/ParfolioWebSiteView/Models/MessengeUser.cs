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

        [MinLength(3, ErrorMessage = "Minmum Length 3 Character")]
        [MaxLength(150, ErrorMessage = "Maxmum Length 150 Character")]
        [Required(ErrorMessage = "Subject is required.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [MinLength(5,ErrorMessage ="Minmum Length 5 Character")]
        [MaxLength(150,ErrorMessage = "Maxmum Length 150 Character")]
        [EmailAddress(ErrorMessage = "Email format is valid")]
        public string Email { get; set; }

        [MinLength(5, ErrorMessage = "Minmum Length 5 Character")]
        [MaxLength(150, ErrorMessage = "Maxmum Length 150 Character")]
        [Required(ErrorMessage = "Subject is required.")]
        public string Subject { get; set; }

        [MinLength(20, ErrorMessage = "Minmum Length 20 Character")]
        [MaxLength(150, ErrorMessage = "Maxmum Length 3000 Character")]
        [Required(ErrorMessage = "Subject is required.")]
        public string Description { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
