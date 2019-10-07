using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Data.Entities
{
    public class Cart :BaseEntity
    {
        public string ClientId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public DateTime DatePurchased { get; set; }
        public bool IsInCart { get; set; }

        public virtual Product Product { get; set; }
    }
}
