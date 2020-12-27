using System;
namespace Restauranti.Dto.Models
{
    public class BaseDto : IDto
    {
        public BaseDto()
        {}

        public Guid Guid { get; set; } = Guid.NewGuid();

        public long Id { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime InsertDate { get; set; } = DateTime.Now;

        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
