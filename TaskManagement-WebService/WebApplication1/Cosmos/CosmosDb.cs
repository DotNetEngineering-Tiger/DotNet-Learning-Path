
namespace WebApplication1.Cosmos
{
    public class CosmosDb : ICosmosDb
    {
        public Task AddOrUpdate(string containerName, object data)
        {
            throw new NotImplementedException();
        }

        public Task getItemById(string containerName, string Id)
        {
            throw new NotImplementedException();
        }

        public Task GetItems(string containerName)
        {
            throw new NotImplementedException();
        }
    }
}
