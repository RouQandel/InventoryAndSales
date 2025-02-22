using AccessDataLayer.Entities;
using AccessDataLayer.Repositories;
using System.Threading.Tasks;

namespace BusinessLayer.Managers;

public class OrderManager
{
    private readonly GenericRepo<Order> _orderRepository;

    public OrderManager(GenericRepo<Order> orderRepository)
    {
        _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
    }

    // Fixed AddOrder method
    public async Task<CreateOrder?> AddOrderAsync(CreateOrder orderDto)
    {
        // Mapping DTO to Entity
        var orderEntity = new Order
        {
            OrderData = orderDto.OrderData,
           
            TotalAmount = orderDto.TotalAmount
        };

        var addedOrder = await _orderRepository.AddAsync(orderEntity);
        if (addedOrder != null)
        {
            await _orderRepository.SaveChangesAsync();

            // Convert back to DTO before returning
            return new CreateOrder
            {
                Id = addedOrder.OrderId,  // Assuming Order has OrderId
                OrderData = addedOrder.OrderData,
                CustomerId = addedOrder.CustomerId,
                TotalAmount = addedOrder.TotalAmount
            };
        }
        return null;
    }

    
    public async Task DeleteOrderAsync(long id)
    {
        await _orderRepository.DeleteAsync(id);
        await _orderRepository.SaveChangesAsync();
    }
}
