using AccessDataLayer.Enums;

namespace BusinessLayer.DTOs;

public class CreateProductDto
{
    public string ProductName { get; set; } = string.Empty;
    public int UnitPrice { get; set; }
    public int QuantityInStock { get; set; } 
    public CategoryEnum? Category { get; set; }
    public int SupId { get; set; }

}