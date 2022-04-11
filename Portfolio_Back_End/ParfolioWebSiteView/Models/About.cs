using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParfolioWebSiteView.Models
{
    public class About
    {
        [ForeignKey("User")]
        public virtual string Id { get; set; }
        public User User { get; set; }
        [Column(TypeName ="ntext")]
        [MinLength(10,ErrorMessage ="Mimum Length 10")]
        public string Descriptoion { get; set; }
        [MaxLength(150,ErrorMessage ="Maximum Length 150")]
        [MinLength(3,ErrorMessage ="Mimum Length 3")]
        public string MainSkill { get; set; }
        public virtual List<SkillCode> SkillCodes { get; set; }
    }
}
