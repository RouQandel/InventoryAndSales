using AccessDataLayer.Entities;

namespace BusinessLayer;

public class DeleteProductDto
{
    public string ProductName { get; set; }
    public long ProductId { get; set; }
}
public static class DeleteMappingExtensions
{
    public static DeleteProductDto ToDeleteProductDto(this Product product)
    {
        return new DeleteProductDto
        {
            ProductName = product.ProductName,
            ProductId = product.ProductId
        };
    }
}
