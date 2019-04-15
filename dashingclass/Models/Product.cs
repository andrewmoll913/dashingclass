using System.ComponentModel.DataAnnotations;

namespace dashingclass.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }

        [Required, StringLength(255), Display(Name = "Type")]
        public string ProductType { get; set; }
        [Required, StringLength(255), Display(Name = "Name")]
        public string ProductName { get; set; }
        [Required, StringLength(255), Display(Name = "Brand")]
        public string ProductBrand { get; set; }

        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Cost")]
        public decimal ProductCost { get; set; }

        [Display(Name = "Color")]
        public string ProductColor { get; set; }

        [Display(Name = "Size")]
        public string ProductSize { get; set; }

        [Display(Name = "Status")]
        public string ProductStatus { get; set; }

        [Display(Name = "Quantity")]
        public int ProductQuantity { get; set; }
    }
}