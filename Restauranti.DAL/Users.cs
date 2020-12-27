using System;
using System.Collections.Generic;

namespace Restauranti.DAL
{
    public partial class Users
    {
        public long Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime InsertDate { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public long? RestaurantId { get; set; }
        public Guid Guid { get; set; }

        public virtual Restaurants Restaurant { get; set; }
    }
}
