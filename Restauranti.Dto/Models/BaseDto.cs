using System;
namespace Restauranti.Dto.Models
{
    public class BaseDto
    {
        public Guid? guid { get; set; }

        public long Id { get; set; }

        public bool IsActive { get; set; }

        public DateTime InsertDate { get; set; }
    }
}
