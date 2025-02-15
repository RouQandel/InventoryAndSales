
namespace AccessDataLayer.Entities;

public class Order
{
    public int OrderId { get; set; } // Primary Key
    public DateTime OrderData { get; set; } = DateTime.Now;
    public int TotalAmount { get; set; }

    // Navigation Property

    public ICollection<Product> Products { get; set; } = new HashSet<Product>();

    // Foreign Key
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}
