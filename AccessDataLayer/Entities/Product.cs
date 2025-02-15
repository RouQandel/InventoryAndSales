using System.ComponentModel.DataAnnotations.Schema;

namespace AccessDataLayer.Entities;

public class Product
{


    //navigation property

    //foreign key
    [ForeignKey("Category")]
    public int CategoryId { get; set; } 
    public Category Category { get; set; } = null!;
}
