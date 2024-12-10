
using Microsoft.Azure.Cosmos;
using System.Threading;

namespace WebApplication1.Cosmos
{
    public class CosmosDb<TItem> : ICosmosDb<TItem>
    {
        private readonly CosmosClient _client;

        public CosmosDb(CosmosClient client)
        {
            _client = client;
        }

        public async Task<ItemResponse<TItem>> AddOrUpdate(string containerName, TItem data)
        {
            return await _client.GetContainer("", containerName).UpsertItemAsync(data).ConfigureAwait(false);
        }

        public Task<TItem> getItemById(string containerName, string Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TItem>> GetItems(string containerName)
        {
            throw new NotImplementedException();
        }
    }
}
