using AccessDataLayer.Entities;

namespace BusinessLayer;

public class DeleteOrder
{
    public int orderId { get; set; }
}
public static class DeleteOrderMappingExtensions
{
    public static DeleteOrder ToDeleteOrder(this Order order)
    {
        return new DeleteOrder
        {
            orderId = order.OrderId
        };
    }
}