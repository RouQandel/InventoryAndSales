using AccessDataLayer.Entities;

namespace BusinessLayer;

public class CreateOrder
{
     public string CustomerName { get; set; }
     public int TotalAmount { get; set; }
     public List<Product>  Products { get; set; } = new List<Product>();
}
public static class CreateOrderMappingExtensions
{
    public static CreateOrder ToCreateOrder(this Order order)
    {
        return new CreateOrder
        {
            CustomerName = order.Customer.CustomerName,
            TotalAmount = order.TotalAmount,
            Products = order.Products.ToList()
        };
    }
}
