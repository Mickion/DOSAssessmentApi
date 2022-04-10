using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOSUsersApi.Data;
using DOSUsersApi.Models;

namespace DOSUsersApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            var users = _userRepository.GetAllUsers();
            return Ok(users);
        }

        //GET api/users/{id}
        [HttpGet("{id}")]
        public ActionResult <User> GetUserById(int id)  
        {
            var user = _userRepository.GetUserById(id);
            return Ok(user);
        }
    }
}
