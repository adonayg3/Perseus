using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Perseus.Modules.DataProcessor.Core.Entities;
using Perseus.Modules.DataProcessor.Core.Repositories;

namespace Perseus.Modules.DataProcessor.Core.DAL.Repositories
{
    internal class InMemoryAssetRepository : IAssetRepository
    {
        //Not thread-safe
        private readonly List<Asset> _assets = new();

        public async Task<IReadOnlyList<Asset>> GetAllAsync()
        {
            await Task.CompletedTask;
            return _assets;
        }
        public Task<Asset> GetAsync(long id) => Task.FromResult(_assets.SingleOrDefault(x => x.Id == id));
        
        public Task AddAsync(Asset asset)
        {
            _assets.Add(asset);
            return Task.CompletedTask;
        }

        public Task UpdateAsync(Asset asset) => Task.CompletedTask;

        public Task DeleteAsync(Asset asset)
        {
            _assets.Remove(asset);
            return Task.CompletedTask;
        }
    }
}