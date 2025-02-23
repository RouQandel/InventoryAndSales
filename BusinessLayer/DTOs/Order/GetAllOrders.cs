namespace BusinessLayer.DTOs.Order;

public class GetAllOrders
{
	public long Id { get; set; }
    public DateTime OrderData { get; set; }
	public int TotalAmount { get; set; }

}