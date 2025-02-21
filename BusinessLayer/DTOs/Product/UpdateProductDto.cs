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
    public int SupId { get; set; }
}
public static class UpdateMappingExtensions
{
    public static UpdateProductDto ToUpdateProduct(this Product product)
    {
        return new UpdateProductDto
        {
            ProductId = product.ProductId,
            ProductName = product.ProductName,
            UnitPrice = product.UnitPrice,
            QuantityInStock = product.QuantityInStock,
            Category = product.Category,
            SupId = product.SupId
        };
    }
}
