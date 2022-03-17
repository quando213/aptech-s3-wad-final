using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoDucQuanWADFinal.Models
{
    public class Category
    {
        [Key]
        [Display(Name = "Category ID")]
        public string CategoryID { get; set; }
        [Display(Name = "Category name")]
        [Required]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}