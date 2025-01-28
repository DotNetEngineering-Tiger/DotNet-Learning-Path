using System;
using WebApplication1.Cosmos;
using WebApplication1.DTO;

namespace WebApplication1.Orchestrators
{
    public class Task : ITask
    {
        private readonly ICosmosDb<TaskDTO> _cosmosDb;
        private readonly string container = "task";
        public Task(ICosmosDb<TaskDTO> cosmosDb)
        {
            _cosmosDb = cosmosDb;
        }
        public async Task<TaskDTO> GetTaskByID(string taskID)
        {
            return await _cosmosDb.getItemById(container, taskID);
        }

        public Task<List<TaskDTO>> GetTasks()
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateTasks(TaskUpdateDTO update_tasks)
        {
            throw new NotImplementedException();
        }
    }
}

