using System;
using WebApplication1.DTO;

namespace WebApplication1.Orchestrators
{
    public class Status : IStatus
    {
        public Task<TaskStatusDTO> GetstatusByID(string taskID)
        {
            throw new NotImplementedException();
        }

        public Task<List<TaskStatusDTO>> GetTasksfileteredbystatus()
        {
            throw new NotImplementedException();
        }

        public Task<string> TaskUpdate(TaskUpdateDTO update_status)
        {
            throw new NotImplementedException();
        }
    }
}


