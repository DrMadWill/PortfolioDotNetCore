using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class Seal
    {
        [Key]
        public int Id { get; set; }

        public User User { get; set; }
        public string UserId { get; set; }

        public Prodact Prodact { get; set; }
        public int ProdactId { get; set; }

        public float Count { get; set; }
        public float Price { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

    }
}
