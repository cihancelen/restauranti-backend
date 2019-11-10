using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Restauranti.DAL.Repositories.Abstract.Category;
using Restauranti.Entities.Models;
using Dapper;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Restauranti.DAL.Repositories.Concrete.Category
{
    public class CategoryRepository : BaseRepository<Entities.Models.Category>, ICategoryRepository
    {
        public async Task<List<Entities.Models.Category>> GetCategoriesByRestaurant(long restaurantId)
        {
            var categories = (await Connection.QueryAsync<Entities.Models.Category>($@"select * from categories where restaurantId = ${restaurantId}"));

            return categories.AsList();
        }
    }
}
