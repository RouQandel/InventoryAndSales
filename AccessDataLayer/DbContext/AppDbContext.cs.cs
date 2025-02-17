
using AccessDataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccessDataLayer;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order>  Orders { get; set; }
    public DbSet<Customer> Customers  { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }


}
