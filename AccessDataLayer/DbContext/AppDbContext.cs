using AccessDataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccessDataLayer;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
   
}
