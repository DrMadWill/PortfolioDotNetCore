﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class Achievements
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Name Required")]
        [MaxLength(100,ErrorMessage = "So Long Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Name Required")]
        public int Count { get; set; }
        [Required(ErrorMessage = "Name Required")]
        [MaxLength(200,ErrorMessage ="So Long Icon")]
        public string Icon { get; set; }

        public User User { get; set; }
        public string UserId { get; set; }


    }
}
