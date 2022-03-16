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

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [MaxLength(200)]
        [Required]
        public string Icon { get; set; }

        [Column(TypeName = "ntext")]
        public string Descriptoion { get; set; }

        public User User { get; set; }
        public string UserId { get; set; }


    }
}
