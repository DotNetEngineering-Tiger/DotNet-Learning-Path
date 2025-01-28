using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO;
using WebApplication1.Orchestrators;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUser _user;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        //POST /api/users: Create a new user.
        [HttpPost("create_user/{id}")]

        public IActionResult CreateUser(UserCreateDTO createuser)
        {
            var create = new UserCreateDTO { };
            return Ok(createuser);
        }
        
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
        
        public async Task<IActionResult> GetUserAsync(string ID)
        {
            var user = await _user.GetUserByID(ID);
            if (user is null)
            {
                return NotFound();
            }
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
