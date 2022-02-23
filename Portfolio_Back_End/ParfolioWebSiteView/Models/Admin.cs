using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        [StringLength(25)]
        [MinLength(10)]
        public string Login { get; set; }
        public string Password { get; set; }

    }
}
