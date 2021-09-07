using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace My.Asp.Net.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Title")]
        public virtual string Title { get; set; }

        [Display(Name = "Subtitle")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Text")]
        public virtual string Text { get; set; }

        [Display(Name = "Image")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "MetaTitle")]
        public virtual string MetaTitle { get; set; }

        [Display(Name = "MetaDescription")]
        public virtual string MetaDescription { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

    }
}
