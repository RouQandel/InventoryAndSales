using AccessDataLayer.Entities;
using AccessDataLayer.Repositories;
using BusinessLayer.DTOs.Order;


namespace BusinessLayer.Managers;

public class OrderManager
{
    private readonly GenericRepo<Order> _orderRepository;

    public OrderManager(GenericRepo<Order> orderRepository)
    {
        _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
    }


	public async Task<CreateOrder?> AddOrderAsync(CreateOrder orderDto)
	{
		// Mapping DTO to Entity
		var orderEntity = new Order
		{
			OrderData = orderDto.OrderData,
			Customer = orderDto.Customer,
			TotalAmount = orderDto.TotalAmount
		};

		await _orderRepository.AddAsync(orderEntity);
		await _orderRepository.SaveChangesAsync();

		
		return orderDto;
	}


    public async Task DeleteOrderAsync(long id)
    {
        await _orderRepository.DeleteAsync(id);
		await _orderRepository.SaveChangesAsync();
    }
	public async Task<List<GetAllOrders>> GetAllOrdersAsync()
	{
		var orders = await _orderRepository.GetAllAsync();

		// Map entities to DTOs
		return orders.Select(o => new GetAllOrders
		{
			Id = o.OrderId,
			OrderData = o.OrderData,
			TotalAmount = o.TotalAmount
		}).ToList();
	}
}
