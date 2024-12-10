using System;
using WebApplication1.DTO;

namespace WebApplication1.Orchestrators
{
    //get status
    //get ID
    //update Status

    public interface IStatus
	{
        public Task<List<TaskStatusDTO>> GetTasksfileteredbystatus();

        public Task<string> TaskUpdate(TaskUpdateDTO update_status);

        public Task<TaskStatusDTO> GetstatusByID(string taskID);
    }
}

