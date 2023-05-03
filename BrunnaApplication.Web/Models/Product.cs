using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BrunnaApplication.Web.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Required]
        [Precision(18,2)]
        public decimal Price { get; set; } = 0.0m;
        [Required]
        public string ImageUrl { get; set; } = string.Empty;
        [Required]
        public bool IsInStock { get; set; } = true;

        [Required]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = null!;

    }
}
