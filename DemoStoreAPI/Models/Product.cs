using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DemoStoreAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        public string Name { get; set; } = String.Empty;
        
        public string Sku { get; set; } = String.Empty;
        public string? Description { get; set; } = String.Empty;

        public string? Image { get; set; } = String.Empty;
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        
        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }
    }
}
