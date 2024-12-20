﻿using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        //POST /api/users: Create a new user.
        //GET /api/users: Get all users.
        [HttpGet("users")]
        public IActionResult GetAllUsers()
        {
            var users = new List<UserDTO>
            { };
            return Ok(users);
        }

        //GET /api/users/{userId} Get user details by userId.
        [HttpGet("UserID")]
        
        public IActionResult GetUser(string ID)
        {
            var user = new UserDTO { };
            return Ok(user); 
        }

        //PUT /api/users/{userId}Update user details.
        [HttpPut("update_users/{id}")]

        public IActionResult UserUpdate (string id,UserCreateDTO update)
        {
           var update_users = new UserUpdateDTO { } ;
           return Ok(update_users);
        }
    }
}
