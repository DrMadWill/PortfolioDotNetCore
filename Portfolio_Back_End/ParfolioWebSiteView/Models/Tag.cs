using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class Tag
    {

        public virtual int Id { get; set; }

        [MaxLength(250)]
        [Required]
        public string Name { get; set; }
        public virtual List<BlogToTag> BlogToTags { get; set; }
    }
}
