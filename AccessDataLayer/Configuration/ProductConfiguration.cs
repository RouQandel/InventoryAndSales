using AccessDataLayer.Entities;
using AccessDataLayer.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccessDataLayer.Configuration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(o => o.ProductId);

        builder.Property(o => o.ProductName)
            .IsRequired().HasMaxLength(50);

        builder.Property(o => o.UnitPrice)
            .IsRequired();

        builder.Property(o => o.QuantityInStock)
            .IsRequired();

        builder.Property(o => o.Category)
          .HasConversion(v => v.ToString(), //converts the enum to its string representation when storing it in the database.
        v => (CategoryEnum)Enum.Parse(typeof(CategoryEnum), v)) //converts the string back to the enum when reading from the database.
          .HasDefaultValue(CategoryEnum.Other)//.ToString()) // Set default value as "Other"
          .IsRequired(false); // Optional property

       builder.HasMany(p => p.Orders)
              .WithMany(o => o.Products)
              .UsingEntity(j => j.ToTable("ProductOrders"));

        builder.HasOne(p => p.Supplier)
               .WithMany(s => s.Products)
               .HasForeignKey(p => p.SupId);
    }
}
