using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AccessDataLayer.Entities
{
   public class Supplier
   {
        [Key]
        public long SupId { get; set; }
        public string SupName { get; set; } = string.Empty;

        // Navigation Property
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
