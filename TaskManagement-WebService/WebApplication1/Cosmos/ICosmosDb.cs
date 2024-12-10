using Microsoft.Azure.Cosmos;

namespace WebApplication1.Cosmos
{
    public interface ICosmosDb<TItem>
    {
        public Task<ItemResponse<TItem>> AddOrUpdate(string containerName, TItem data);

        public Task<TItem> getItemById(string containerName, string Id);

        public Task<List<TItem>> GetItems(string containerName);
    }
}
