using System;
using System.Collections.Generic;

namespace Restauranti.DAL
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public long Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime InsertDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ColourCode { get; set; }
        public long? RestaurantId { get; set; }
        public Guid Guid { get; set; }

        public virtual Restaurants Restaurant { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
