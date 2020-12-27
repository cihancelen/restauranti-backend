using System;
namespace Restauranti.Entities
{
    public interface IEntity
    {
        long Id { get; set; }

        Guid Guid { get; set; }

        bool IsActive { get; set; }

        DateTime InsertDate { get; set; }

        DateTime ModifiedDate { get; set; }
    }
}
