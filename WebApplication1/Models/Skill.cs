using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Skill
    {
        [Required]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Seniority")]
        [UIHint("GridForeignKey")]
        public int SeniorityId { get; set; }

        [Required]
        [DisplayName("Enabled")]
        public bool Enabled { get; set; }
    }
}