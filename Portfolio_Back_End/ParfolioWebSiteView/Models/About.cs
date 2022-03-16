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
        public string Id { get; set; }
        public User User { get; set; }
        
        [Column(TypeName ="ntext")]
        public string Descriptoion { get; set; }
        [MaxLength(150)]
        public string MainSkill { get; set; }
        public List<Skill> Skills { get; set; }
        public List<SkillCode> SkillCodes { get; set; }
        public bool IsShow { get; set; }

    }
}
