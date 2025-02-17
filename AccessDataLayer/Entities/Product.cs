using System.ComponentModel.DataAnnotations.Schema;

namespace AccessDataLayer.Entities;

public class Product
{

    // Navigation Property
    public ICollection<Order> Orders { get; set; } = new HashSet<Order>();

}
