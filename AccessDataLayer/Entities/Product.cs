using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AccessDataLayer.Enums;

namespace AccessDataLayer.Entities;

public class Product
{

    
    [Key]
    public long ProductId { get; set; } // Primary Key
    
    public string ProductName { get; set; } = string.Empty; //Must have Name 

    public  decimal UnitPrice { get; set; } //must be decimal 

    public int QuantityInStock { get; set; } = 0; //if no input =0 by default

    public CategoryEnum? Category { get; set; } //CategoryEnum type and can be Null


    // Navigation Property  

    public ICollection<Order> Orders { get; set; } = new HashSet<Order>();

    [ForeignKey("Supplier")]
    public long SupId { get; set; }
    public Supplier Supplier { get; set; } = null!;


}
