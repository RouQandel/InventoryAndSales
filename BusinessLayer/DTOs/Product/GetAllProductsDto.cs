using AccessDataLayer.Entities;

namespace BusinessLayer;

public class GetAllProductsDto
{
    public long Id { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public decimal UnitPrice { get; set; }
    public int QuantityInStock { get; set; }
    public string Category { get; set; } = string.Empty;
    public string SupName { get; set; } 

}
