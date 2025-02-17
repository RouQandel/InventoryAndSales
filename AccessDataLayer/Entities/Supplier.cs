using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDataLayer.Entities
{
   public class Supplier
   {


        [ForeignKey("Product")]
        public required int ProductId { get; set; } //foreign key for 1 to many relation with product (make it in fluit API also <3 ) 
    }
}
