using WebApplication1.DTO;

namespace WebApplication1.Orchestrators
{
    public interface ITask
    {
        public Task<List<TaskDTO>> GetTasksFilteredByStatus(string tasks);

        public Task<string> UpdateTasks(TaskUpdateDTO update_tasks);

        public Task<UserDTO> GetTaskByID(string taskID);


    }
}

