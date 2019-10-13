using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Restauranti.Entities.Models.Relations;

namespace Restauranti.Entities.Models
{
    public class Unit: BaseEntity
    {
        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        [ForeignKey("RestaurantId")]
        public virtual Restaurant Restaurant { get; set; }

        public virtual ICollection<ProductUnits> ProductUnits { get; set; }

    }
}
