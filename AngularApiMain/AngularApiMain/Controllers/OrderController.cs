using AngularApiMain.Context;
using AngularApiMain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularApiMain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public OrderController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/order/user/{userId}/restaurant/{restaurantId}
        [HttpGet("user/{userId}/restaurant/{restaurantId}")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrderByUserIdAndRestaurantId(int userId, int restaurantId)
        {
            var orders = await _dbContext.Orders
                .Where(o => o.UserId == userId && o.RestaurantId == restaurantId)
                .ToListAsync();

            if (orders == null || orders.Count == 0)
            {
                return NotFound();
            }

            return orders;
        }

        // GET: api/order/{orderId}
        [HttpGet("{orderId}")]
        public async Task<ActionResult<Order>> GetOrderById(int orderId)
        {
            var order = await _dbContext.Orders.FindAsync(orderId);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // POST: api/order
        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder(Order order)
        {
            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrderById), new { orderId = order.OrderId }, order);
        }

        // PUT: api/order/{orderId}
        [HttpPut("{orderId}")]
        public async Task<IActionResult> UpdateOrder(int orderId, Order order)
        {
            if (orderId != order.OrderId)
            {
                return BadRequest();
            }

            _dbContext.Entry(order).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(orderId))
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

        // DELETE: api/order/{orderId}
        [HttpDelete("{orderId}")]
        public async Task<IActionResult> DeleteOrder(int orderId)
        {
            var order = await _dbContext.Orders.FindAsync(orderId);

            if (order == null)
            {
                return NotFound();
            }

            _dbContext.Orders.Remove(order);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderExists(int orderId)
        {
            return _dbContext.Orders.Any(e => e.OrderId == orderId);
        }
        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrderByUserId(int userId)
        {
            var orders = await _dbContext.Orders
                .Where(o => o.UserId == userId)
                .ToListAsync();

            if (orders == null || orders.Count == 0)
            {
                return NotFound();
            }

            return orders;
        }

        // GET: api/order/restaurant/{restaurantId}
        [HttpGet("restaurant/{restaurantId}")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrderByRestaurantId(int restaurantId)
        {
            var orders = await _dbContext.Orders
                .Where(o => o.RestaurantId == restaurantId)
                .ToListAsync();

            if (orders == null || orders.Count == 0)
            {
                return NotFound();
            }

            return orders;
        }

        // POST: api/order/update/user/{userId}
        [HttpPost("update/user/{userId}")]
        public async Task<IActionResult> UpdateOrderByUserId(int userId, List<Order> orders)
        {
            foreach (var order in orders)
            {
                if (order.UserId != userId)
                {
                    return BadRequest("Invalid UserId in the request.");
                }
                _dbContext.Entry(order).State = EntityState.Modified;
            }

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // Handle exceptions as needed
                throw;
            }

            return NoContent();
        }
        


        // POST: api/order/update/restaurant/{restaurantId}
        [HttpPost("update/restaurant/{restaurantId}")]
        public async Task<IActionResult> UpdateOrderByRestaurantId(int restaurantId, List<Order> orders)
        {
            foreach (var order in orders)
            {
                if (order.RestaurantId != restaurantId)
                {
                    return BadRequest("Invalid RestaurantId in the request.");
                }
                _dbContext.Entry(order).State = EntityState.Modified;
            }

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // Handle exceptions as needed
                throw;
            }

            return NoContent();
        }

    }
}
    