using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restauranti.Entities.Models.Relations
{
    public class ProductMenus
    {
        public long ProductId { get; set; }

        public long MenuId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [ForeignKey("MenuId")]
        public Menu Menu{ get; set; }
    }
}
