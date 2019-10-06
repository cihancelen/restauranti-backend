using System;
namespace Restauranti.Entities.Models
{
    public class User: BaseEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime Birthday { get; set; }

        public DateTime LastLoginTime { get; set; }

    }
}
