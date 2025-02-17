using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AccessDataLayer.Entities
{
   public class Supplier
   {
        [Key]
        public int SupId { get; set; }
        public string SupName { get; set; } = string.Empty;

        [ForeignKey("Product")]
        public required int ProductId { get; set; } //foreign key for 1 to many relation with product (make it in fluit API also <3 ) 
    }
}
