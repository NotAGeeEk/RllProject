using AngularApiMain.Context;
using AngularApiMain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularApiMain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public RestaurantController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Restaurants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Restaurant>>> GetRestaurants()
        {
            return await _dbContext.Restaurants.ToListAsync();
        }

        // GET: api/Restaurants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Restaurant>> GetRestaurant(int id)
        {
            var restaurant = await _dbContext.Restaurants.FindAsync(id);

            if (restaurant == null)
            {
                return NotFound();
            }

            return restaurant;
        }

        // POST: api/Restaurants
        [HttpPost]
        public async Task<ActionResult<Restaurant>> PostRestaurant(Restaurant restaurant)
        {
            if (restaurant == null)
            {
                return BadRequest();
            }

            _dbContext.Restaurants.Add(restaurant);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction("GetRestaurant", new { id = restaurant.Id }, restaurant);
        }

        // PUT: api/Restaurants/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRestaurant(int id, Restaurant restaurant)
        {
            if (id != restaurant.Id)
            {
                return BadRequest();
            }

            _dbContext.Entry(restaurant).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestaurantExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Restaurants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestaurant(int id)
        {
            var restaurant = await _dbContext.Restaurants.FindAsync(id);
            if (restaurant == null)
            {
                return NotFound();
            }

            _dbContext.Restaurants.Remove(restaurant);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }
        // GET: api/Restaurant/{id}/fooditems
        [HttpGet("{id}/fooditems")]
        public async Task<ActionResult<IEnumerable<FoodItem>>> GetFoodItemsForRestaurant(int id)
        {
            var foodItems = await _dbContext.FoodItems.Where(item => item.RestaurantId == id).ToListAsync();

            if (foodItems == null || !foodItems.Any())
            {
                return NotFound();
            }

            return foodItems;
        }

        // POST: api/Restaurants/{restaurantId}/add-food-item
        [HttpPost("{restaurantId}/add-food-item")]
        public async Task<IActionResult> AddFoodItem(int restaurantId, [FromBody] FoodItem foodItem)
        {
            if (foodItem == null)
            {
                return BadRequest();
            }

            var restaurant = await _dbContext.Restaurants.FindAsync(restaurantId);
            if (restaurant == null)
            {
                return NotFound(new { Message = "Restaurant Not Found" });
            }

            // Associate the food item with the restaurant
            foodItem.RestaurantId = restaurantId;

            _dbContext.FoodItems.Add(foodItem);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction("GetFoodItem", new { id = foodItem.Id }, foodItem);
        }


        private bool RestaurantExists(int id)
        {
            return _dbContext.Restaurants.Any(e => e.Id == id);
        }

    }
}
