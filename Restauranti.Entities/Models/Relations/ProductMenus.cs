using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restauranti.Entities.Models.Relations
{
    [Table("ProductMenus")]
    public class ProductMenus
    {
        [Key]
        public long Id { get; set; }

        public long ProductId { get; set; }

        public long MenuId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [ForeignKey("MenuId")]
        public Menu Menu{ get; set; }
    }
}
