using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Data.Entities
{
   public class ProductType :BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
