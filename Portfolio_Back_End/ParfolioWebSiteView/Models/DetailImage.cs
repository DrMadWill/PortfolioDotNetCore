using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class DetailImage
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Image { get; set; }

        public PortfolioDetail PortfolioDetail { get; set; }
        public int PortfolioDetailId { get; set; }

    }
}
