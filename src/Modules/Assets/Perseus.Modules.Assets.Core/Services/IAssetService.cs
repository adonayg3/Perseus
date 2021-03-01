using System.Collections.Generic;
using System.Threading.Tasks;
using Perseus.Modules.Assets.Core.DTO;

namespace Perseus.Modules.Assets.Core.Services
{
    public interface IAssetService
    {
        Task<IReadOnlyList<AssetDto>> GetAllAsync();
        Task<AssetDto> GetAsync(long id);
        Task AddAsync(AssetDto assetDto);
        Task UpdateAsync(AssetDto assetDto);
        Task DeleteAsync(long id);
    }
}