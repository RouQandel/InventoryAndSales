using AccessDataLayer.Configuration;
using AccessDataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AccessDataLayer;

public class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    public DbSet<Product> Products { get; set; } 
    public DbSet<Order> Orders { get; set; } 
    public DbSet<Customer> Customers { get; set; } 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerConfiguration());

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    if (!optionsBuilder.IsConfigured)
    //    {
    //        optionsBuilder.UseSqlServer("Server=ROU\\SQLSERVER;Database=Inventory_SalesSystem;Trusted_Connection=True;");
    //    }
    //}


}
