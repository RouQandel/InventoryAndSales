using System.ComponentModel.DataAnnotations;

namespace AccessDataLayer.Entities;

public class Category
{
    [Key]
    public int CategoryId { get; set; } // Primary Key
    public string CategoryName { get; set; } = string.Empty;
    // Navigation Property
    public ICollection<Product> Products { get; set; } = new HashSet<Product>();
}
