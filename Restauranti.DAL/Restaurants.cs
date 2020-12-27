using System;
using System.Collections.Generic;

namespace Restauranti.DAL
{
    public partial class Restaurants
    {
        public Restaurants()
        {
            Categories = new HashSet<Categories>();
            Menus = new HashSet<Menus>();
            Products = new HashSet<Products>();
            Units = new HashSet<Units>();
            Users = new HashSet<Users>();
        }

        public long Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime InsertDate { get; set; }
        public string Name { get; set; }
        public Guid Guid { get; set; }

        public virtual ICollection<Categories> Categories { get; set; }
        public virtual ICollection<Menus> Menus { get; set; }
        public virtual ICollection<Products> Products { get; set; }
        public virtual ICollection<Units> Units { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
