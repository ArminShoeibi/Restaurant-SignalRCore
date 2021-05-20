using Microsoft.EntityFrameworkCore;
using Restaurant.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        public DbSet<Food> Foods { get; set; }
    }
}
