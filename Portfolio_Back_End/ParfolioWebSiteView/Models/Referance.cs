using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class Referance
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(150, ErrorMessage = "Maximum Length 150")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Title is Required")]
        [MaxLength(500, ErrorMessage = "Maximum Length 500")]
        public string Title { get; set; }

        [MaxLength(150)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        public User User { get; set; }
        public string UserId { get; set; }

    }
}
