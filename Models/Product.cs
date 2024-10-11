using System.ComponentModel.DataAnnotations;

namespace ClimateControlWebsite.Models
{
    public class Product
    {
        public int Id { get; set; } // Primary Key

        [Required]
        [StringLength(100)]
        public string Name { get; set; } // Name of the product

        [Required]
        [StringLength(500)]
        public string Description { get; set; } // Description of the product

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; } // Price of the product
    }
}
