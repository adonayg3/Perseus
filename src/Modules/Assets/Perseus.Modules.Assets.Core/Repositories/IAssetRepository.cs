using System.Collections.Generic;
using System.Threading.Tasks;
using Perseus.Modules.Assets.Core.Entities;

namespace Perseus.Modules.Assets.Core.Repositories
{
    public interface IAssetRepository
    {
        Task<IReadOnlyList<Asset>> GetAllAsync();
        Task<Asset> GetAsync(long id);
        Task AddAsync(Asset asset);
        Task UpdateAsync(Asset asset);
        Task DeleteAsync(Asset asset);
    }
}