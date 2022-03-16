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
        [Required]
        public string Title { get; set; }

        [MaxLength(150)]
        [Required]
        public string Image { get; set; }

        public DateTime Date { get; set; }

        public PortfolioCategory PortfolioCategory { get; set; }
        public int PortfolioCategoryId { get; set; }

        public PortfolioDetail PortfolioDetail { get; set; }

        public User User { get; set; }
        public string UserId { get; set; }

    }
}
