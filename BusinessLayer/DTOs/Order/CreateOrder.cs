using AccessDataLayer.Entities;

namespace BusinessLayer;

public class CreateOrder
{
    public Customer Customer { get; set; } = new Customer();
    public int TotalAmount { get; set; }
    public DateTime OrderData { get; set; }
}
