
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccessDataLayer.Entities;

public class Order
{
    [Key]
    public int OrderId { get; set; } // Primary Key
    public DateTime OrderData { get; set; } = DateTime.Now;
    public int TotalAmount { get; set; }

    // Navigation Property

    public ICollection<Product> Products { get; set; } = new HashSet<Product>();

    [ForeignKey("Customer")]
    // Foreign Key
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
}
