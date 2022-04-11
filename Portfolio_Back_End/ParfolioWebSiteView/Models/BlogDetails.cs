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
        public virtual int Id { get; set; }
        public virtual Blog Blog { get; set; }

        [Column(TypeName = "ntext")]
        [Required(ErrorMessage = "Description is Required")]
        public string Description { get; set; }
        public virtual IList<Commet> Commets { get; set; }
    }
}
