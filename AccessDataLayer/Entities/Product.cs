using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AccessDataLayer.Enums;

namespace AccessDataLayer.Entities;

public class Product
{

    
    [Key]
    public int ProductId { get; set; } // Primary Key
    
    public  string? ProductName { get; set; } //Must have Name 

    public  long UnitPrice { get; set; } //must be long 

    public int QuantityInStock { get; set; } = 0; //if no input =0 by default

    public CategoryEnum? Category { get; set; } //CategoryEnum type and can be Null


    // Navigation Property

    public ICollection<Order> Orders { get; set; } = new HashSet<Order>();

    [ForeignKey ("Supplier")]
    public int SupId { get; set; }
    public Supplier Supplier { get; set; } = null!;     


}
