using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class Service
    {

        public int Id { get; set; }

        [MaxLength(100,ErrorMessage =" Maxumum Length 100")]
        [MinLength(3,ErrorMessage =" Minumum Length 3")]
        [Required(ErrorMessage = " Name Is Required")]
        public string Name { get; set; }
        [MaxLength(200, ErrorMessage = " Maxumum Length 200")]
        [MinLength(3, ErrorMessage = " Minumum Length 3")]
        [Required(ErrorMessage = " Icon Is Required")]
        public string Icon { get; set; }

        [MaxLength(700,ErrorMessage ="Maxumum Length 400")]
        [MinLength(3, ErrorMessage = " Minumum Length 3")]
        [Required(ErrorMessage = " Descriptoion Is Required")]
        public string Descriptoion { get; set; }

        public User User { get; set; }
        [Required]
        public string UserId { get; set; }


    }
}
