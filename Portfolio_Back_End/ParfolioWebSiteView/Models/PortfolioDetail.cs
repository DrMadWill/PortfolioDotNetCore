﻿using System;
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
        public int Id { get; set; }
        public Portfolio Portfolio { get; set; }
        [MaxLength(150)]
        public string Client { get; set; }
        [Column(TypeName = "ntext")]
        public string Descriptoion { get; set; }
        [MaxLength(200)]
        public string LocatoionURL { get; set; }
        public List<DetailImage> DetailImages { get; set; }
    }
}
