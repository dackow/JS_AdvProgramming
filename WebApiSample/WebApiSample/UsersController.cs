using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSample
{
    //[Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static readonly List<User> _users = new List<User>();

        [HttpGet]
        [Route("Users")]
        [ProducesResponseType(typeof(IEnumerable<User>), 200)]
        [ProducesResponseType(204)]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            if(_users.Any())
                return Ok(_users);
            else
                return NoContent();

        }

        [HttpGet]
        [Route("Users/{id}")]
        [ProducesResponseType(typeof(User), 200)]
        [ProducesResponseType(404)]
        public ActionResult<User> GetUser(int id)
        {
            var user = _users.FirstOrDefault(x => x.Id == id);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        [HttpDelete]
        [Route("Users/Delete/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public IActionResult DeleteUser(int id)
        {
            if (_users.Any(u => u.Id == id))
            {
                _users.RemoveAll(u => u.Id == id);
                return Ok();
            }
            else
                return NotFound();
        }

        [HttpPost]
        [Route("Users/Add")]
        [ProducesResponseType(typeof(User), 201)]
        [ProducesResponseType(400)]
        public ActionResult<User> AddUser([FromBody] User user)
        {
            if (!_users.Any(u => u.Id == user.Id))
            {
                _users.Add(user);
                return Created($"Users/{user.Id}", user);
            }
            else
            {
                return BadRequest();
            }
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
