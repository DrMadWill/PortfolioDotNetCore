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

        [NotMapped]
        public List<Commet> CommentChildren { get; set; }
        // Html Loaction 
        [NotMapped]
        public string HtmlId { get { return "comment" + Id; } }

        // For Ajax Send Data
        [NotMapped]
        public string UserName { get; set; }

        // For Ajax Send Data
        [NotMapped]
        public string Image { get; set; }


        
        //public async Task<List<Commet>> ComentChildernAsync(IQueryable<Commet> soruce,int id)
        //{
        //    // CommentChildren Check Null Or Clear
        //    if (CommentChildren == null) CommentChildren = new List<Commet>();
        //    else CommentChildren.Clear();

        //    // Select Children Comment
        //    var coments = await soruce.Where(dr => dr.ParentId == id).ToListAsync();

        //    foreach (var item in coments)
        //        if (item.IsChild)
        //            coments.InsertRange(
        //                coments.IndexOf(item) + 1,
        //                (IEnumerable<Commet>)ComentChildernAsync(soruce, item.Id)
        //                );
        //    CommentChildren.AddRange(coments);
        //    return CommentChildren;
        //}


    }
}
