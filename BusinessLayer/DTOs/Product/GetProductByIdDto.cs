
namespace BusinessLayer.DTOs.Product;

public class GetProductByIdDto
{
    public long Id { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string CategoryNane { get; set; } = string.Empty;
  
}
