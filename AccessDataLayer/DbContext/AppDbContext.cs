﻿using AccessDataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AccessDataLayer;

public class AppDbContext : DbContext
{
 
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    public DbSet<Product> Products { get; set; } 
    public DbSet<Order> Orders { get; set; } 
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Supplier> Suppliers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }

}
