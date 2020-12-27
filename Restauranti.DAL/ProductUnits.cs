using System;
using System.Collections.Generic;

namespace Restauranti.DAL
{
    public partial class ProductUnits
    {
        public long ProductId { get; set; }
        public long UnitId { get; set; }
        public long Id { get; set; }

        public virtual Products Product { get; set; }
        public virtual Units Unit { get; set; }
    }
}
