using AccessDataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccessDataLayer.Configuration;
public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o => o.OrderId);

        builder.Property(o => o.OrderData)
            .IsRequired();

        builder.Property(o => o.TotalAmount)
            .IsRequired();

        //builder.HasMany(o => o.Products)
        //    .WithOne()
        //    .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(o => o.Customer)
            .WithMany(c => c.Orders) 
            .HasForeignKey(o => o.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
