using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restauranti.Entities.Models
{
    [Table("Categories")]
    public class Category: BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ColourCode { get; set; }

        public long? RestaurantId { get; set; }

        [ForeignKey("RestaurantId")]
        public virtual Restaurant Restaurant { get; set; }
    }
}
