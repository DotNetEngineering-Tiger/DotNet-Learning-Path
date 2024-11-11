using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : Controller
    {
        [HttpGet("task")]
        public IActionResult GetAllTasks()
        {
            var tasks = new List<TaskDTO>
            { };
            return Ok(tasks);
        }

        //GET /api/users/{userId} Get user details by userId.
        [HttpGet("TaskID")]

        public IActionResult GetTaskDetails(int ID)
        {
            var task = new TaskDTO { };
            return Ok(task);
        }

        //PUT /api/users/{userId}Update user details.
        [HttpPut("update_taskdetails/{id}")]

        public IActionResult TaskUpdate(int id, TaskCreateDTO update)
        {
            var update_tasks = new TaskUpdateDTO { };
            return Ok(update_tasks);
        }
    }
}

