using AngularApiMain.Context;
using AngularApiMain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections.Generic;

namespace AngularApiMain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly AppDbContext _authContext;

        public AdminController(AppDbContext appDbContext)
        {
            _authContext = appDbContext;
        }
        [HttpPost("add-restaurant")]
        public async Task<IActionResult> AddRestaurant([FromBody] Restaurant restaurant)
        {
            if (restaurant == null)
                return BadRequest();

            // You can add any validation or authorization checks here.

            await _authContext.Restaurants.AddAsync(restaurant);
            await _authContext.SaveChangesAsync();

            return Ok(new
            {
                Message = "Restaurant Added Successfully!"
            });
        }

        [HttpGet("view-restaurants")]
        public async Task<IActionResult> ViewRestaurants()
        {
            var restaurants = await _authContext.Restaurants.ToListAsync();

            return Ok(restaurants);
        }

        [HttpDelete("delete-restaurant/{restaurantId}")]
        public async Task<IActionResult> DeleteRestaurant(int restaurantId)
        {
            var restaurant = await _authContext.Restaurants.FindAsync(restaurantId);

            if (restaurant == null)
                return NotFound(new { Message = "Restaurant Not Found" });

            // You can add any validation or authorization checks here.

            _authContext.Restaurants.Remove(restaurant);
            await _authContext.SaveChangesAsync();

            return Ok(new
            {
                Message = "Restaurant Deleted Successfully!"
            });
        }

        [HttpPut("update-restaurant")]
        public async Task<IActionResult> UpdateRestaurant([FromBody] Restaurant restaurant)
        {
            if (restaurant == null)
                return BadRequest();

            var existingRestaurant = await _authContext.Restaurants.FindAsync(restaurant.Id);

            if (existingRestaurant == null)
                return NotFound(new { Message = "Restaurant Not Found" });

            // You can add any validation or authorization checks here.

            existingRestaurant.Name = restaurant.Name;
            // Update other properties as needed.

            await _authContext.SaveChangesAsync();

            return Ok(new
            {
                Message = "Restaurant Updated Successfully!"
            });
        }

        [HttpPost("add-user")]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            if (user == null)
                return BadRequest();

            // You can add any validation or authorization checks here.

            await _authContext.Users.AddAsync(user);
            await _authContext.SaveChangesAsync();

            return Ok(new
            {
                Message = "User Added Successfully!"
            });
        }

        [HttpGet("view-users")]
        public async Task<IActionResult> ViewUsers()
        {
            var users = await _authContext.Users.ToListAsync();

            return Ok(users);
        }

        [HttpDelete("delete-user/{userId}")]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            var user = await _authContext.Users.FindAsync(userId);

            if (user == null)
                return NotFound(new { Message = "User Not Found" });

            // You can add any validation or authorization checks here.

            _authContext.Users.Remove(user);
            await _authContext.SaveChangesAsync();

            return Ok(new
            {
                Message = "User Deleted Successfully!"
            });
        }

        [HttpPut("update-user")]
        public async Task<IActionResult> UpdateUser([FromBody] User user)
        {
            if (user == null)
                return BadRequest();

            var existingUser = await _authContext.Users.FindAsync(user.Id);

            if (existingUser == null)
                return NotFound(new { Message = "User Not Found" });

            // You can add any validation or authorization checks here.

            existingUser.FirstName = user.FirstName;
            existingUser.LastName = user.LastName;
            // Update other properties as needed.

            await _authContext.SaveChangesAsync();

            return Ok(new
            {
                Message = "User Updated Successfully!"
            });
        }






        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] Admin adminObj)
        {
            if (adminObj == null)
                return BadRequest();

            var admin = await _authContext.Admins.FirstOrDefaultAsync(x => x.UserName == adminObj.UserName && x.Password == adminObj.Password);

            if (admin == null)
                return NotFound(new { Message = "Admin Not Found" });

            var adminDetails = new
            {
                admin.Id,
                admin.FirstName,
                admin.LastName,
                admin.UserName,
                admin.Email,
            };

            return Ok(new
            {
                Message = "Admin Login Success!",
                Admin = adminDetails
            });
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAdmin([FromBody] Admin adminObj)
        {
            if (adminObj == null)
                return BadRequest();

            await _authContext.Admins.AddAsync(adminObj);
            await _authContext.SaveChangesAsync();

            return Ok(new
            {
                Message = "Admin Registered!"
            });

        }
    }
}
