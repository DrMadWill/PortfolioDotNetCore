using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class SkillCode
    {
        public virtual int Id { get; set; }

        [MaxLength(75,ErrorMessage ="Maximum Length 75")]
        [MinLength(3,ErrorMessage ="Minum Length 4")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Percent is Required")]
        [Column(TypeName = "tinyint")]
        public byte Percent { get; set; }

        public virtual About About { get; set; }
        [Required]
        public virtual string AboutId { get; set; }

    }
}
