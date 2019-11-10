using System;
using System.ComponentModel.DataAnnotations;

namespace Restauranti.Entities
{
    public class BaseEntity: IEntity
    {
        public BaseEntity()
        {
            this.Guid = Guid.NewGuid();
        }

        [Key]
        public long Id { get; set; }

        public Guid Guid { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime InsertDate { get; set; } = DateTime.Now;
    }
}
