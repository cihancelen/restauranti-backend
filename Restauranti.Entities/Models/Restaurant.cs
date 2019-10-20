using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restauranti.Entities.Models
{
    [Table("Restaurants")]
    public class Restaurant : BaseEntity
    {
        public string Name { get; set; }

    }
}
