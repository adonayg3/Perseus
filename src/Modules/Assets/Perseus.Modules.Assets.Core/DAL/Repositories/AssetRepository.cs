using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Perseus.Modules.Assets.Core.Entities;
using Perseus.Modules.Assets.Core.Repositories;

namespace Perseus.Modules.Assets.Core.DAL.Repositories
{
    public class AssetRepository : IAssetRepository
    {
        private readonly AssetsDbContext _context;
        private readonly DbSet<Asset> _assets;

        public AssetRepository(AssetsDbContext context)
        {
            _context = context;
            _assets = _context.Assets;
        }

        public async Task<IReadOnlyList<Asset>> GetAllAsync() => await _assets.ToListAsync();

        public Task<Asset> GetAsync(long id) => _assets.SingleOrDefaultAsync(x => x.Id == id);

        public async Task AddAsync(Asset asset)
        {
            await _assets.AddAsync(asset);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Asset asset)
        {
            _assets.Update(asset);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Asset asset)
        {
            _assets.Remove(asset);
            await _context.SaveChangesAsync();
        }
    }
}