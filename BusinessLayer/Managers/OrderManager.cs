using AccessDataLayer.Entities;
using AccessDataLayer.Repositories;

namespace BusinessLayer.Managers;

public class OrderManager
{
    private readonly GenericRepo<Order> _orderRepository = new GenericRepo<Order>();
    public async Task<Order?> AddOrder(Order order)
    {
        return await _orderRepository.Add(order);
    }
    public async void DeleteOrder(long id) => _orderRepository.Delete(id);


}
