using AccessDataLayer.Configuration;
using AccessDataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccessDataLayer;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public AppDbContext()
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=KHALED_ALTABEY;Database=Inventory_Sales;Trusted_Connection=True;TrustServerCertificate=True;");
    }
    public DbSet<Product> Products { get; set; } 
    public DbSet<Order> Orders { get; set; } 
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerConfguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
    }

}
