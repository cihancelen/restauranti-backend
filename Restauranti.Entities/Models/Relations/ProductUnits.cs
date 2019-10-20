using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restauranti.Entities.Models.Relations
{
    [Table("ProductUnits")]
    public class ProductUnits
    {
        [Key]
        public long Id { get; set; }

        public long ProductId { get; set; }

        public long UnitId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }
    }
}
