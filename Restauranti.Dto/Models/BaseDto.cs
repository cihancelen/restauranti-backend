using System;
namespace Restauranti.Dto.Models
{
    public class BaseDto
    {
        public BaseDto()
        {
            Guid = new Guid();

            IsActive = true;

            InsertDate = DateTime.Now;
        }

        public Guid? Guid { get; set; }

        public long Id { get; set; }

        public bool IsActive { get; set; }

        public DateTime InsertDate { get; set; }
    }
}
