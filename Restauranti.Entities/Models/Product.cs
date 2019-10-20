using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Restauranti.Entities.Models.Relations;

namespace Restauranti.Entities.Models
{
    [Table("Products")]
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("RestaurantId")]
        public virtual Restaurant Restaurant { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public virtual ICollection<ProductUnits> ProductUnits { get; set; }

        public virtual ICollection<ProductMenus> ProductMenus { get; set; }
    }
}
