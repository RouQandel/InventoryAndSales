using System.ComponentModel.DataAnnotations.Schema;

namespace AccessDataLayer.Entities;

public class Product
{
    public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
}
