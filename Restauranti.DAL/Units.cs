using System;
using System.Collections.Generic;

namespace Restauranti.DAL
{
    public partial class Units
    {
        public Units()
        {
            ProductUnits = new HashSet<ProductUnits>();
        }

        public long Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime InsertDate { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public long? RestaurantId { get; set; }
        public Guid Guid { get; set; }

        public virtual Restaurants Restaurant { get; set; }
        public virtual ICollection<ProductUnits> ProductUnits { get; set; }
    }
}
