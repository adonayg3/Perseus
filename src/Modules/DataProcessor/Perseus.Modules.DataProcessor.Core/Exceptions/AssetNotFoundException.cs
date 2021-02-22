using Perseus.Shared.Abstractions.Exceptions;

namespace Perseus.Modules.DataProcessor.Core.Exceptions
{
    internal class AssetNotFoundException : CustomException
    {
        public long AssetId { get; set; }
        public AssetNotFoundException(long assetId) : 
            base($"Asset with ID: '{assetId}' was not found.")
        {
            AssetId = assetId;
        }
    }
}