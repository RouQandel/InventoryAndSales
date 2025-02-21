using AccessDataLayer.Entities;
using AccessDataLayer.Repositories;
using AccessDataLayer.Repositories.Product;
using BusinessLayer.DTOs.Product;

namespace BusinessLayer.Managers;

public class ProductManage
{
    private readonly ProductRepository _productRepository = new ProductRepository();

    public  List<GetAllProductsDto> GetAll()
    {
        var products =  _productRepository.GetAll();
        // Business Logic

        // Mapping   Entity  ====>  DTO

        var productDtoList = products
       .Select(p => new GetAllProductsDto
       {
           Id = p.ProductId,
           ProductName = p.ProductName,
           UnitPrice = p.UnitPrice,
           QuantityInStock = p.QuantityInStock,
           Category = p.Category.ToString(),
           SupplierName = p.Supplier.SupName

       })
       .ToList();

        return   productDtoList;
    }
    public GetProductByIdDto? GetById(int id)
    {
        var product = _productRepository.GetById(id);
        var productDto = product == null ? null : new GetProductByIdDto
        {
            Id = product.ProductId,
            ProductName = product.ProductName,
            Price = product.UnitPrice,
            CategoryNane = product.Category.ToString()

        };
        return productDto;
    }

    public void AddProduct(CreateProductDto productDto)
    {
        // mapping  dto   -->  entity

        var product = new Product
        {
            ProductName = productDto.ProductName,
            UnitPrice = productDto.UnitPrice,
            QuantityInStock = productDto.QuantityInStock,
            Category = productDto.Category,
            SupId = productDto.SupId
        };

        _productRepository.AddProduct(product);
    }
    public void UpdateProduct(UpdateProductDto productDto)
    {
        var product = new Product
        {
            ProductId = productDto.ProductId,
            ProductName = productDto.ProductName,
            UnitPrice = productDto.UnitPrice,
            QuantityInStock = productDto.QuantityInStock,
            Category = productDto.Category,
            SupId = productDto.SupId
        };

        _productRepository.UpdateProductById(product.ProductId, product);
    }
    public void DeleteProduct(long id) => _productRepository.DeleteProduct(id);
    

}
