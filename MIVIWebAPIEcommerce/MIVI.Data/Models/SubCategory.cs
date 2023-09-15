using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MIVI.Data.Models
{
     public class SubCategory
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Sub Category Name")]
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }

}
