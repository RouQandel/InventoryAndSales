using AccessDataLayer.Enums;
using AccessDataLayer.Entities;

namespace BusinessLayer;

public class CreateProductDto
{
    public string ProductName { get; set; } = string.Empty;
    public long UnitPrice { get; set; }
    public int QuantityInStock { get; set; }
    public CategoryEnum? Category { get; set; }
    public int SupId { get; set; }

}
public static class CreateMappingExtensions
{
    public static Product ToProduct(this CreateProductDto createProductDto)
    {
        return new Product
        {
            ProductName = createProductDto.ProductName,
            UnitPrice = createProductDto.UnitPrice,
            QuantityInStock = createProductDto.QuantityInStock,
            Category = createProductDto.Category,
            SupId = createProductDto.SupId
        };
    }
}