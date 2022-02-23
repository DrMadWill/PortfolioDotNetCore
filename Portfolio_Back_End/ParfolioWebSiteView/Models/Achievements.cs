using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class Achievements
    {
        [MaxLength(1)]
        public int Id { get; set; }
        public int WorksComplate { get; set; }
        public int YearsExperoence { get; set; }
        public int TotalClents { get; set; }
        public int AwardWon { get; set; }
    }
}
