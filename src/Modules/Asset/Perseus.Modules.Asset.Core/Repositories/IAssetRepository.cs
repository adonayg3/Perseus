using System.Collections.Generic;
using System.Threading.Tasks;
using Perseus.Modules.Asset.Core.Entities;

namespace Perseus.Modules.Asset.Core.Repositories
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