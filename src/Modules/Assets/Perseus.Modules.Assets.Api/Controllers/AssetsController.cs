using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Perseus.Modules.Assets.Core.DTO;
using Perseus.Modules.Assets.Core.Services;

namespace Perseus.Modules.Assets.Api.Controllers
{
    internal class AssetsController : BaseController
    {
        private readonly IAssetService _assetService;

        public AssetsController(IAssetService assetService)
        {
            _assetService = assetService;
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<AssetDto>> Get(long id)
        {
            var assetDto = await _assetService.GetAsync(id);
            if (assetDto is null)
            {
                return NotFound();
            }

            return Ok(assetDto);
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<AssetDto>>> GetAll()
            => Ok(await _assetService.GetAllAsync());
        
        [HttpPost]
        public async Task<ActionResult> AddAsync(AssetDto assetDto)
        {
            await _assetService.AddAsync(assetDto);
            return CreatedAtAction(nameof(Get), new {id = assetDto.Id}, null);
        }
        
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(long id, AssetDto assetDto)
        {
            assetDto.Id = id;
            await _assetService.UpdateAsync(assetDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(long id)
        {
            await _assetService.DeleteAsync(id);
            return NoContent();
        }
    }
}