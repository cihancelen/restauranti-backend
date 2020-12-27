using System;
using System.Collections.Generic;

namespace Restauranti.DAL
{
    public partial class ProductMenus
    {
        public long ProductId { get; set; }
        public long MenuId { get; set; }
        public long Id { get; set; }

        public virtual Menus Menu { get; set; }
        public virtual Products Product { get; set; }
    }
}
