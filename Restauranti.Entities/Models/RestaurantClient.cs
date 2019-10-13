using System;
namespace Restauranti.Entities.Models
{
    public class RestaurantClient: BaseEntity
    {
        public string ClientName { get; set; }

        public string Password { get; set; }
    }
}
