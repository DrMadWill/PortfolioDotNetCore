using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class BlogDetails
    {
        [Key, ForeignKey("Blog")]
        public int Id { get; set; }
        public Blog Blog { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        public IList<Commet> Commets { get; set; }

    }
}
