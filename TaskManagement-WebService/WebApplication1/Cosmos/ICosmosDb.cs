namespace WebApplication1.Cosmos
{
    public interface ICosmosDb
    {
        public Task AddOrUpdate(string containerName, Object data);

        public Task getItemById(string containerName, string Id);

        public Task GetItems(string containerName);
    }
}
