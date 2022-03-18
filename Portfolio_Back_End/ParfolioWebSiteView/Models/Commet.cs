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
        public int Id { get; set; }

        public int? ParentId { get; set; }

        [Column(TypeName = "ntext")]
        public string Comment { get; set; }

        public User User { get; set; }
        public string UserId { get; set; }
        public BlogDetails BlogDetails { get; set; }
        public int BlogDetailsId { get; set; }
        public DateTime Date { get; set; }
        public bool IsBlocked { get; set; } = false;

        [NotMapped]
        public string HtmlId { get { return "comment" + Id; } }

    }
}
