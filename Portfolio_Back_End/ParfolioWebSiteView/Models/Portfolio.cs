using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    
    public class Portfolio
    {


        public int Id { get; set; }
        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }

        [MaxLength(150)]
        public string Image { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public PortfolioCategory PortfolioCategory { get; set; }
        public int PortfolioCategoryId { get; set; }

        public PortfolioDetail PortfolioDetail { get; set; }

        public User User { get; set; }
        [Required]
        public string UserId { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        [NotMapped]
        public List<PortfolioCategory> PortfolioCategoriesVM { get; set; }
    }
}
