using System;
using WebApplication1.Cosmos;
using WebApplication1.DTO;

namespace WebApplication1.Orchestrators
{
    public class Status : IStatus
    {
        private readonly ICosmosDb<TaskStatusDTO> _cosmosDb;
        private readonly string container = "status";
        public Status(ICosmosDb<TaskStatusDTO> cosmosDb) 
        {
            _cosmosDb = cosmosDb;
        }
        public async Task<TaskStatusDTO> GetstatusByID(string taskID)
        {
            return await _cosmosDb.getItemById(container, taskID);
        }

        public Task<List<TaskStatusDTO>> GetTasksfileteredbystatus( string status)
        {
            throw new NotImplementedException();
        }

        public Task<string> TaskUpdate(TaskUpdateDTO update_task)
        {
            throw new NotImplementedException();
        }
    }
}


