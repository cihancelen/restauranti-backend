using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Restauranti.Entities.Models.Authentication
{
    public class AppUser: IdentityUser
    {
        [ForeignKey("RestaurantId")]
        public long ResturantId { get; set; }

    }
}
