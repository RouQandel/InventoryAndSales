namespace AccessDataLayer.Repositories.Product;

using System.Reflection.Metadata.Ecma335;
using AccessDataLayer.Entities;
using AccessDataLayer.Enums;

public class ProductRepository
{

    ICollection<Product> ProductsCollection = new HashSet<Product>();

    public ICollection<Product> GetAll() => ProductsCollection;

    public Product? GetById(int _id)=> ProductsCollection.FirstOrDefault(p => p.ProductId == _id);

    public void AddProduct(Product product)
    {
        ProductsCollection.Add(new Product
        {
            ProductName = product.ProductName??string.Empty,
            UnitPrice = product.UnitPrice,
            QuantityInStock = product.QuantityInStock,
            Category = product.Category?? CategoryEnum.Other,
            Orders = product.Orders
        });

    }
     public void UpdateProductById(int _id, Product product)
    {
        var p = ProductsCollection.FirstOrDefault(p => p.ProductId == _id);
        if (p == null)
            return;
        p.ProductName = product.ProductName;
        p.UnitPrice = product.UnitPrice;
        p.QuantityInStock = product.QuantityInStock;
        p.Category = product.Category;
        p.Orders = product.Orders;
    }

    public void DeleteProduct(int _id)
    {
        ProductsCollection.Remove(ProductsCollection.FirstOrDefault(p => p.ProductId == _id));
    }
}
