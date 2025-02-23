namespace AccessDataLayer.Repositories.Product;
using AccessDataLayer.Entities;
using AccessDataLayer.Enums;
using Microsoft.EntityFrameworkCore;

public class ProductRepository
{
    private readonly AppDbContext _dbContext;

    public ProductRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Product>> GetAllAsync() => await _dbContext.Products.ToListAsync();

    public async Task<Product?> GetByIdAsync(long id) => await _dbContext.Products.FindAsync(id);

    public async Task AddProductAsync(Product product)
    {
        if (product == null) throw new ArgumentNullException(nameof(product));

        var newProduct = new Product
        {
            ProductName = product.ProductName ?? string.Empty,
            UnitPrice = product.UnitPrice,
            QuantityInStock = product.QuantityInStock,
            Category = product.Category ?? CategoryEnum.Other,
            Orders = product.Orders,
            SupId = 1
        };

        await _dbContext.Products.AddAsync(newProduct);
    }

    public async Task<bool> UpdateProductByIdAsync(long id, Product updatedProduct)
    {
        var product = await _dbContext.Products.FindAsync(id);
        if (product == null) return false;

        product.ProductName = updatedProduct.ProductName;
        product.UnitPrice = updatedProduct.UnitPrice;
        product.QuantityInStock = updatedProduct.QuantityInStock;
        product.Category = updatedProduct.Category;
        product.Orders = updatedProduct.Orders;
        //product.Supplier.SupName = updatedProduct.Supplier.SupName;

        _dbContext.Products.Update(product);
        return true;
    }

    public async Task<bool> DeleteProductAsync(long id)
    {
        var product = await _dbContext.Products.FindAsync(id);
        if (product == null) return false;

        _dbContext.Products.Remove(product);
        return true;
    }

    public async Task<long> GetMaxIdAsync()
    {
        return await _dbContext.Products.AnyAsync() ?
               await _dbContext.Products.MaxAsync(p => p.ProductId) : 0;
    }

    public async Task<int> SaveChangesAsync() => await _dbContext.SaveChangesAsync();
}
