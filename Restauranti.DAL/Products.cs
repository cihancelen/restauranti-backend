using System;
using System.Collections.Generic;

namespace Restauranti.DAL
{
    public partial class Products
    {
        public Products()
        {
            ProductMenus = new HashSet<ProductMenus>();
            ProductUnits = new HashSet<ProductUnits>();
        }

        public long Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime InsertDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public long? RestaurantId { get; set; }
        public long? CategoryId { get; set; }
        public Guid Guid { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Restaurants Restaurant { get; set; }
        public virtual ICollection<ProductMenus> ProductMenus { get; set; }
        public virtual ICollection<ProductUnits> ProductUnits { get; set; }
    }
}
