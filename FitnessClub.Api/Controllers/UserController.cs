using FitnessClub.Api.Data;
using FitnessClub.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessClub.Api.Controllers
{
    [ApiController]
    [Route("user")]
    public class UsersController : ControllerBase
    {
        private readonly ApiDbContext context = new ApiDbContext();

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            if (context.Users.Any(u => u.Login == user.Login))
            {
                return BadRequest("Логин уже существует");
            }

            context.Users.Add(user);
            context.SaveChanges();

            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            User? user = context.Users.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, User newUser)
        {
            User? user = context.Users.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            user.Login = newUser.Login;
            user.PassHash = newUser.PassHash;

            context.SaveChanges();

            return Ok(user);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            User? user = context.Users.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            context.Users.Remove(user);
            context.SaveChanges();

            return Ok("Пользователь удален");
        }
    }
}