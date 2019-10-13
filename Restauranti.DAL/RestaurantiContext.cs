using System;
using Microsoft.EntityFrameworkCore;

using Restauranti.Entities.Models;
using Restauranti.Entities.Models.Relations;

namespace Restauranti.DAL
{
    public class RestaurantiContext
    {
        public RestaurantiContext() : base("Name=RestaurantiContext")
        {

        }

    }
}
