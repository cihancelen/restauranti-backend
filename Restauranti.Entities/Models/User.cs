using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restauranti.Entities.Models
{
    [Table("Users")]
    public class User: BaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        [ForeignKey("RestaurantId")]
        public virtual Restaurant Restaurant { get; set; }
    }
}
