using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkillCard_CodeFirstEntity.Models.Classes
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        public string Explanation { get; set; }
        public byte Value { get; set; }
    }
}