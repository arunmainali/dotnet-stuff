using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // Instead of `new DotnetdbContext()`, we use Dependency Injection.
        // This is the standard best practice in modern .NET Core applications.
        private readonly DotnetdbContext db;

        public UsersController(DotnetdbContext context)
        {
            db = context;
        }

        // GET: api/Users/GetUsers
        [HttpGet]
        [Route("GetUsers")]
        public List<User> Get()
        {
            return db.Users.ToList();
        }

        // GET: api/Users/GetUserByID/1
        [HttpGet]
        [Route("GetUserByID/{id}")]
        public User Get(int id)
        {
            return db.Users.Where(a => a.Id == id).FirstOrDefault();
        }

        // POST: api/Users/AddUser
        [HttpPost]
        [Route("AddUser")]
        public void Post(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        // PUT: api/Users/UpdateUser/1
        [HttpPut]
        [Route("UpdateUser/{id}")]
        public IActionResult Put(int id, User user)
        {
            var existingUser = db.Users.Find(id);
            if (existingUser == null)
            {
                return NotFound();
            }
            existingUser.Name = user.Name;
            db.SaveChanges();
            return Ok();
        }

        // DELETE: api/Users/DeleteUser/1
        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public IActionResult Delete(int id)
        {
            var user = db.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            db.Users.Remove(user);
            db.SaveChanges();
            return Ok();
        }
    }
}
