using AccessDataLayer.Entities;
using AccessDataLayer.Repositories.Product;
using BusinessLayer.DTOs.Product;


namespace BusinessLayer.Managers;

public class ProductManager
{
    private readonly ProductRepository _productRepository;

    public ProductManager(ProductRepository productRepository)
    {
        _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
    }

    public async Task<List<GetAllProductsDto>> GetAllAsync()
    {
        var products = await _productRepository.GetAllAsync();

        // Mapping: Entity → DTO
        return products.Select(p => new GetAllProductsDto
        {
            Id = p.ProductId,
            ProductName = p.ProductName,
            UnitPrice = p.UnitPrice,
            QuantityInStock = p.QuantityInStock,
            Category = p.Category.ToString(),
            SupName = p.Supplier.SupName
        }).ToList();
    }

    public async Task<GetProductByIdDto?> GetByIdAsync(int id)
    {
        var product = await _productRepository.GetByIdAsync(id);

        if (product == null) return null;

        return new GetProductByIdDto
        {
            Id = product.ProductId,
            ProductName = product.ProductName,
            Price = product.UnitPrice,
            CategoryNane = product.Category.ToString()
        };
    }

    public async Task AddProductAsync(CreateProductDto productDto)
    {
        var product = new Product
        {
            ProductName = productDto.ProductName,
            UnitPrice = productDto.UnitPrice,
            QuantityInStock = productDto.QuantityInStock,
            Category = productDto.Category
    
        };

        await _productRepository.AddProductAsync(product);
        await _productRepository.SaveChangesAsync();
    }

    public async Task<bool> UpdateProductAsync(UpdateProductDto productDto)
    {
        var existingProduct = await _productRepository.GetByIdAsync(productDto.ProductId);
        if (existingProduct == null) return false; 

   
        existingProduct.ProductName = productDto.ProductName;
        existingProduct.UnitPrice = productDto.UnitPrice;
        existingProduct.QuantityInStock = productDto.QuantityInStock;
        existingProduct.Category = productDto.Category;
        existingProduct.Supplier = existingProduct.Supplier;

       
        await _productRepository.UpdateProductByIdAsync(existingProduct.ProductId, existingProduct);

        await _productRepository.SaveChangesAsync();

        return true;
    }


    public async Task<bool> DeleteProductAsync(long id)
    {
        var product = await _productRepository.GetByIdAsync(id);
        if (product == null) return false;

        await _productRepository.DeleteProductAsync(id);
        await _productRepository.SaveChangesAsync();

        return true;
    }
}
