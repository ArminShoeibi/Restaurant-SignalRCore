using Microsoft.AspNetCore.SignalR;
using Restaurant.Data;
using Restaurant.Domain;
using Restaurant.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Web.Hubs
{
    public class FoodsHub : Hub
    {
        private readonly RestaurantDbContext _db;

        public FoodsHub(RestaurantDbContext db)
        {
            _db = db;
        }

        public async Task CreateFood(CreateFoodDto createFoodDto)
        {
            DateTimeOffset now = DateTimeOffset.Now;
            Food newFood = new()
            {
                DateCreated = now,
                DateModified = now,
                Description = createFoodDto.Description,
                Ingredients = createFoodDto.Ingredients,
                Name = createFoodDto.Name,
            };
            await _db.Foods.AddAsync(newFood);
            int saveChangesResult = await _db.SaveChangesAsync();

            await Clients.Caller.SendAsync("CreateFoodResult", Convert.ToBoolean(saveChangesResult));
        }
    }
}
