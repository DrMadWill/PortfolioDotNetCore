using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class SkillCode
    {
        public int Id { get; set; }

        [MaxLength(75)]
        [Required]
        public string Name { get; set; }

        [MaxLength(100)]
        [Required]
        public int Percent { get; set; }

        public About About { get; set; }
        public string AboutId { get; set; }

    }
}
