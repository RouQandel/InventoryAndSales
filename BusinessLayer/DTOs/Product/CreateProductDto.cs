using AccessDataLayer.Enums;
using AccessDataLayer.Entities;

namespace BusinessLayer;

public class CreateProductDto
{
    public string ProductName { get; set; } = string.Empty;
    public decimal UnitPrice { get; set; }
    public int QuantityInStock { get; set; }
    public CategoryEnum? Category { get; set; }
    public string SupName { get; set; }

}
