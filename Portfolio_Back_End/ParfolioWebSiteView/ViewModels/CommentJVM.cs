using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.ViewModels
{
    public class CommentJVM
    {

        public int Id { get; set; }
        public string Comment { get; set; }
        public  string UserId { get; set; }
        public  int BlogDetailsId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public bool IsChild { get; set; }
        public int? ParentId { get; set; }
        public string HtmlId { get; set; }
        public string UserName { get; set; }
        public string Image { get; set; }
        public string ParentUserName { get; set; }
    }
}
