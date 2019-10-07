using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Data.Entities
{
    public abstract  class BaseEntity
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;
    }
}
