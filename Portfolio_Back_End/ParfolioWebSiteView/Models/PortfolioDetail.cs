using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    
    public class PortfolioDetail
    {

        [Key, ForeignKey("Portfolio")]
        public virtual int Id { get; set; }
        public virtual Portfolio Portfolio { get; set; }
        [MaxLength(150)]
        [Required]
        public string Client { get; set; }
        [Column(TypeName = "ntext")]
        public string Descriptoion { get; set; }
        [MaxLength(200)]
        public string LocatoionURL { get; set; }

        [NotMapped]
        public List<IFormFile> Photos { get; set; }

        public virtual List<DetailImage> DetailImages { get; set; }
    }
}
