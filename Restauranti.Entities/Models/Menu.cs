using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Restauranti.Entities.Models.Relations;

namespace Restauranti.Entities.Models
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("RestaurantId")]
        public virtual Restaurant Restaurant { get; set; }

        public virtual ICollection<ProductMenus> ProductMenus { get; set; }
    }
}
