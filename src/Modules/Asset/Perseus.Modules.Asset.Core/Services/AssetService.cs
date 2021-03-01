using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Perseus.Modules.Asset.Core.DTO;
using Perseus.Modules.Asset.Core.Entities;
using Perseus.Modules.Asset.Core.Exceptions;
using Perseus.Modules.Asset.Core.Repositories;

namespace Perseus.Modules.Asset.Core.Services
{
    public class AssetService : IAssetService
    {
        private readonly IAssetRepository _assetRepository;

        public AssetService(IAssetRepository assetRepository)
        {
            _assetRepository = assetRepository;
        }
        public async Task<IReadOnlyList<AssetDto>> GetAllAsync()
        {
            var assets = await _assetRepository.GetAllAsync();
            return assets.Select(asset => new AssetDto
            {
                Symbol = asset.Symbol,
                Name = asset.Name
            }).ToList();
        }

        public async Task<AssetDto> GetAsync(long id)
        {
            var asset = await _assetRepository.GetAsync(id);
            return asset is not null
                ? new AssetDto
                {
                    Id = asset.Id,
                    Symbol = asset.Symbol,
                    Name = asset.Name
                }
                : default;
        }

        public async Task AddAsync(AssetDto assetDto)
        {
            var asset = new Asset
            {
                Symbol = assetDto.Symbol,
                Name = assetDto.Name
            };
            await _assetRepository.AddAsync(asset);
        }

        public async Task UpdateAsync(AssetDto assetDto)
        {
            var asset = await _assetRepository.GetAsync(assetDto.Id);
            if (asset is null)
                throw new AssetNotFoundException(assetDto.Id);

            asset.Symbol = assetDto.Symbol;
            asset.Name = assetDto.Name;
            await _assetRepository.UpdateAsync(asset);
        }

        public async Task DeleteAsync(long id)
        {
            var asset = await _assetRepository.GetAsync(id);
            if (asset is null)
                throw new AssetNotFoundException(id);
            
            await _assetRepository.DeleteAsync(asset);
        }
    }
}