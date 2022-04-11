using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class DetailImage
    {
        public virtual int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Image { get; set; }

        public virtual PortfolioDetail PortfolioDetail { get; set; }
        public virtual int PortfolioDetailId { get; set; }

    }
}
