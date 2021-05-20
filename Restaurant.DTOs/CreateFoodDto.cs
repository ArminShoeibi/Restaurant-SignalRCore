using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DTOs
{
    public record CreateFoodDto
    {
        public string Name { get; init; }
        public string Ingredients { get; init; }
        public string Description { get; init; }
    }
}
