using AccessDataLayer.Entities;
using AccessDataLayer.Enums;

namespace BusinessLayer;

public class UpdateProductDto
{
    public long ProductId { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public decimal UnitPrice { get; set; }
    public int QuantityInStock { get; set; }
    public CategoryEnum? Category { get; set; }
    public string SupName { get; set; }
}
