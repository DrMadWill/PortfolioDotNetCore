using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class Commet
    {
        [Key]
        public virtual int Id { get; set; }
        [Column(TypeName = "ntext")]
        [Required]
        [MinLength(2)]
        public string Comment { get; set; }
        public virtual User User { get; set; }
        [Required]
        public virtual string UserId { get; set; }
        public virtual BlogDetails BlogDetails { get; set; }
        public virtual int BlogDetailsId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public bool IsBlocked { get; set; } = false;
        public bool IsChild { get; set; }

        public Commet Parent { get; set; }
        public int? ParentId { get; set; }
       
        // Html Loaction 
        [NotMapped]
        public string HtmlId { get { return "comment" + Id; } }

    }
}
