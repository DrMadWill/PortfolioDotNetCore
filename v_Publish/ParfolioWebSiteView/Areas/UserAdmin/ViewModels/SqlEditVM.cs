using System.ComponentModel.DataAnnotations;

namespace ParfolioWebSiteView.Areas.UserAdmin.ViewModels
{
    public class SqlEditVM
    {
        [Required]
        [MinLength(3)]
        public string Code { get; set; }
    }
}
