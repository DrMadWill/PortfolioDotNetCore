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
        public int Id { get; set; }

        [MaxLength(75)]
        public string Name { get; set; }

        [Column(TypeName ="ntext")]
        public string Descriptoion { get; set; }


        public int MyProperty { get; set; }


        
        public List<Skill> Skills { get; set; }
        public List<SkillCode> SkillCodes { get; set; }


    }
}
