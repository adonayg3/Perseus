using System.ComponentModel.DataAnnotations;

namespace Perseus.Modules.DataProcessor.Core.DTO
{
    public class AssetDto
    {
        public long Id { get; set; }
        [Required]
        public string Symbol { get; set; }
        [Required]
        public string Name { get; set; }
    }
}