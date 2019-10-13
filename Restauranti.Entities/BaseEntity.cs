using System;
using System.ComponentModel.DataAnnotations;

namespace Restauranti.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            InsertDate = DateTime.Now;

            IsActive = true;
        }

        [Key]
        public long Id { get; set; }

        public bool IsActive { get; set; }

        public DateTime InsertDate { get; set; }
    }
}
