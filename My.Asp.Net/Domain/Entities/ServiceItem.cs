using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace My.Asp.Net.Domain.Entities
{
    public class ServiceItem : EntityBase
    {

        [Required(ErrorMessage ="Need filling Title")]
        [Display(Name = "Title")]
        public override string Title { get; set; }

        [Display(Name = "Short description")]
        public override string Subtitle { get; set; }

        [Display(Name = "Text Page")]
        public override string Text { get; set; } 
    }
}
