using System;
namespace Restauranti.Dto.Models.Category
{
    public class CategoryDto: BaseDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ColourCode { get; set; }

        public long RestaurantId { get; set; }
    }
}
