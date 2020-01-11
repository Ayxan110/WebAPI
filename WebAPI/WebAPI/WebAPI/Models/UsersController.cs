using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private static readonly List<User> _users;
        static UsersController()
        {
            _users = new List<User>
            {
                new User{ Id = 1,Name = "Aykhan",Surname = "Dadashov",Email = "ayxan@gmail.com"},
                new User{ Id = 2,Name = "Aykhan2",Surname = "Dadashov2",Email = "ayxan2@gmail.com"}
            };
        }
        [HttpGet]
        public IEnumerable<User> GetAllUser()
        {
            return _users;
        }
        [HttpPost]
        public void AddUser([FromBody] User user)
        {
            _users.Add(user);
        }
        [HttpPut("{Email}")]
        public void UpdateUser(string Email,User user)
        {
            var updated = _users.Where(x => x.Email == Email).FirstOrDefault();
            updated.Name = user.Name;
        }
        [HttpDelete("{Email}")]
        public void DeleteUser(string Email)
        {
            _users.RemoveAll(x => x.Email == Email);
        }
    }
}
