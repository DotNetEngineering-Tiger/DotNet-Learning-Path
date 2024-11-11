using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskStatuscontroller : Controller
    {
        //PUT / api / task - status /{ taskId}: Update task status.
        //GET / api / task - status: Get tasks filtered by status.
        //GET / api / task - status / history /{ taskId}: Get status change history of a task.

        [HttpGet("{status}")]
        public IActionResult GetTasksfileteredbystatus(string status)
        {
            var sampleTask1 = new TaskStatusDTO
            {
                Status = "ToDo",
                TaskId = 1,
                Title = "New Task"
            };
            var sampleTask2 = new TaskStatusDTO
            {
                Status = "Doing",
                TaskId = 2,
                Title = "New Task"
            };
            var sampleTask3 = new TaskStatusDTO
            {
                Status = "Review",
                TaskId = 3,
                Title = "New Task"
            };
            var sampleTask4 = new TaskStatusDTO
            {
                Status = "Done",
                TaskId = 4,
                Title = "New Task"
            };
            var tasks = new List<TaskStatusDTO>
            {
                sampleTask1,sampleTask2,sampleTask3,sampleTask4
            };

            if (status == "All")
            {
                return Ok(tasks);
            }

            var filteredTasks = tasks.Where(x => x.Status == status);
            return Ok(filteredTasks);
        }
        [HttpGet("Id/{taskId}")]
        public IActionResult GetTasksbyTasksID(int taskId)
        {
            var sampleTask1 = new TaskStatusDTO
            {
                Status = "ToDo",
                TaskId = 1,
                Title = "New Task"
            };
            var sampleTask2 = new TaskStatusDTO
            {
                Status = "Doing",
                TaskId = 2,
                Title = "New Task"
            };
            var sampleTask3 = new TaskStatusDTO
            {
                Status = "Review",
                TaskId = 3,
                Title = "New Task"
            };
            var sampleTask4 = new TaskStatusDTO
            {
                Status = "Done",
                TaskId = 4,
                Title = "New Task"
            };
            var tasks = new List<TaskStatusDTO>
            {
                sampleTask1,sampleTask2,sampleTask3,sampleTask4
            };

            var FilteredTask = tasks.Where(x => x.TaskId == taskId);
            return Ok(FilteredTask);
        }
        [HttpPut("updatestatus/{taskId}/{status}")]
        public IActionResult UpdateTaskStatusbyTaskId(int taskId, string status)
        {
            return Ok(new TaskStatusDTO());
        }
    }

}

