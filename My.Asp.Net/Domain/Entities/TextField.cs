using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace My.Asp.Net.Domain.Entities
{
    public class TextField : EntityBase
    {

        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Name Title")]
        public override string Title { get; set; } = "Information page";

        [Display(Name = "Text Page")]
        public override string Text { get; set; } = "Text is filled in by the admin ";

    }
}
