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
        [Required]
        [MinLength(2)]
        public string Comment { get; set; }
        public User User { get; set; }
        [Required]
        public string UserId { get; set; }
        public BlogDetails BlogDetails { get; set; }
        public int BlogDetailsId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public bool IsBlocked { get; set; } = false;

        [NotMapped]
        public string HtmlId { get { return "comment" + Id; } }

    }
}
