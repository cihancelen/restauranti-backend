using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restauranti.Entities.Models
{
    public class Category: BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ColourCode { get; set; }

        [ForeignKey("RestaurantId")]
        public virtual Restaurant Restaurant { get; set; }
    }
}
