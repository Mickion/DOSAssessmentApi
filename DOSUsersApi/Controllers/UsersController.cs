using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOSUsersApi.Data;
using DOSUsersApi.Models;
using AutoMapper;
using DOSUsersApi.DTOs;

namespace DOSUsersApi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        //GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> GetAllUsers()
        {
            var users = _userRepository.GetAllUsers();
            if (users == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<UserDto>>(users));
        }

        //GET api/users/{id}
        [HttpGet("{id}")]
        public ActionResult <UserDto> GetUserById(int id)  
        {
            var user = _userRepository.GetUserById(id);
            if(user == null)
            {
                return NotFound();                
            }
            return Ok(_mapper.Map<UserDto>(user));

        }
    }
}
