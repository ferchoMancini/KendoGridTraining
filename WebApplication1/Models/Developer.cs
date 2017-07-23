using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Developer
    {
        [Required]
        [Range(1, int.MaxValue)]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Age")]
        public int Age { get; set; }

        public IList<Skill> AllSkill { get; set; }
    }
}