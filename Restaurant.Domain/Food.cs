using System;

namespace Restaurant.Domain
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset? DateDeleted { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateModified { get; set; }
    }
}
