using AccessDataLayer.Entities;

namespace BusinessLayer;

public class CreateOrder
{
     public string CustomerName { get; set; }
    public int TotalAmount { get; set; }
}
public static class CreateOrderMappingExtensions
{
    public static CreateOrder ToCreateOrder(this Order order)
    {
        return new CreateOrder
        {
            CustomerName = order.Customer.CustomerName,
            TotalAmount = order.TotalAmount
        };
    }
}
