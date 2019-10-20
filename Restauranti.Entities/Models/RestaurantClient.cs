using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restauranti.Entities.Models
{
    [Table("RestaurantClients")]
    public class RestaurantClient: BaseEntity
    {
        public string ClientName { get; set; }

        public string Password { get; set; }
    }
}
