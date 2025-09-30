namespace PrimerParcialProgra.Models
{
    public class Product
    {
        public int Id { get; set; } // PK
        public string Name { get; set; } 
        public string? Description { get; set; } // nullable
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; } // nullable
    }
}