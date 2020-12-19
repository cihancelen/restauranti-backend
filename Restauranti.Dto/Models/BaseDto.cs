using System;
namespace Restauranti.Dto.Models
{
    public class BaseDto : IDto
    {
        public BaseDto()
        {
            this.Guid = System.Guid.NewGuid();
        }

        public Guid Guid { get; set; }

        public long Id { get; set; }

        public bool IsActive { get; set; }

        public DateTime InsertDate { get; set; }
    }
}
