using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200, ErrorMessage = "Maxum Limit 200")]
        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Image { get; set; }
        [MaxLength(350)]
        [Required(ErrorMessage = "Front Description is Required")]
        public string Description { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public BlogCategory BlogCategory { get; set; }
        public int BlogCategoryId { get; set; }

        public List<BlogToTag> BlogToTags { get; set; }

        public User User { get; set; }
        public string UserId { get; set; }

        public BlogDetails BlogDetails { get; set; }

        [NotMapped]
        public TimeSpan Time { get { return (DateTime.Now.Subtract(Date));} }

       

    }
}
