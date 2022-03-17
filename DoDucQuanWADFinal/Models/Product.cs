using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoDucQuanWADFinal.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "Product ID")]
        public string ProductId { get; set; }
        [Display(Name = "Product name")]
        [Required]
        public string ProductName { get; set; }
        [Display(Name = "Supplier ID")]
        public string SupplierId { get; set; }
        [ForeignKey("Category")]
        [Display(Name = "Category")]
        public string CategoryId { get; set; }
        [Display(Name = "Quantity per unit")]
        public int QuantityPerUnit { get; set; }
        [Display(Name = "Unit price")]
        [Required]
        public float UnitPrice { get; set; }
        [Display(Name = "Units in stock")]
        public int UnitsInStock { get; set; }
        [Display(Name = "Units on order")]
        public int UnitsOnOrder { get; set; }
        [Display(Name = "Reorder level")]
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public virtual Category Category { get; set; }
    }
}