using System.ComponentModel.DataAnnotations;

namespace AccessDataLayer.Entities;
public class Customer
{
    // Primary Key
    [Key]
    public int CustomerId { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string ContactInfo { get; set; } = string.Empty;

    // Navigation Property
    public ICollection<Order> Orders { get; set; } = new HashSet<Order>();

}
