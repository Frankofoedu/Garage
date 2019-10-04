using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Data.Entities
{
   public class Product :BaseEntity
    {
        public int TypeId { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ProductType ProductType { get; set; }
    }
}
