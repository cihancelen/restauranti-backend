using System;
namespace Restauranti.Dto.Models
{
    public interface IDto
    {
        long Id { get; set; }

        Guid Guid { get; set; }

        bool IsActive { get; set; }

        DateTime InsertDate { get; set; }

        DateTime ModifiedDate { get; set; }
    }
}
