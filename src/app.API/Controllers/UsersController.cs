using System;
using System.Collections.Generic;
using app.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace app.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        readonly List<User> _users = new List<User>
        {
            new User("Alejandro Perez", "wi_alejo@hotmail.com", 32),
            new User("Sandra Jowett", "sandra@hotmail.com", 3)
        };

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _users;
        }

        [HttpGet]
        public IActionResult Post(User user)
        {
            throw new NotImplementedException();
        }
    }
}