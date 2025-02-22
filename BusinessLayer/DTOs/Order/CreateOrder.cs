using AccessDataLayer.Entities;

namespace BusinessLayer;

public class CreateOrder
{
    public long Id { get; set; }
     public long CustomerId { get; set; }
     public int TotalAmount { get; set; }
     public DateTime OrderData { get; set; }
    public List<Product>  Products { get; set; } = new List<Product>();
}
