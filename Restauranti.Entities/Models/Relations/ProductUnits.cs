using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restauranti.Entities.Models.Relations
{
    public class ProductUnits
    {
        public long ProductId { get; set; }

        public long UnitId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }
    }
}
