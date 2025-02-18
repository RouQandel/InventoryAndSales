using AccessDataLayer.Entities;

namespace BusinessLayer;

public class GetAllProductsDto
{
    public long Id { get; set; }
    public string ProductName { get; set; } = string.Empty;
    public decimal UnitPrice { get; set; }
    public int QuantityInStock { get; set; }
    public string Category { get; set; } = string.Empty;
    public string SupplierName { get; set; } = string.Empty;

}
public static class GetAllMappingExtensions
{
    public static GetAllProductsDto ToGetAllProductsDto(this Product product)
    {
        return new GetAllProductsDto
        {
            Id = product.ProductId,
            ProductName = product.ProductName,
            UnitPrice = product.UnitPrice,
            QuantityInStock = product.QuantityInStock,
            Category = product.Category.ToString(),
            SupplierName = product.Supplier.SupName
        };
    }
    public static IEnumerable<GetAllProductsDto> ToGetAllProductsDtos(this IEnumerable<Product> products)
    {
        return products.Select(p => p.ToGetAllProductsDto());
    }
}

