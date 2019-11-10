using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Restauranti.DAL.Repositories.Abstract.Category
{
    public interface ICategoryRepository : IBaseRepository<Restauranti.Entities.Models.Category>
    {
        Task<List<Restauranti.Entities.Models.Category>> GetCategoriesByRestaurant(long restaurantId);
    }
}
