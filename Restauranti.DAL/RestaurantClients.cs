using System;
using System.Collections.Generic;

namespace Restauranti.DAL
{
    public partial class RestaurantClients
    {
        public long Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime InsertDate { get; set; }
        public string ClientName { get; set; }
        public string Password { get; set; }
        public Guid Guid { get; set; }
    }
}
