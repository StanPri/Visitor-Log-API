using System.Collections.Generic;
using VL.Business.Entities;


namespace VL.Business.Services.Interface
{
    public interface IAssetService
    {
        AssetDTO GetAssetByID(int assetID);
        IEnumerable<AssetDTO> GetAllAssets();
        int CreateAsset(AssetDTO assetDTO);
        bool UpdateAsset(int assetID, AssetDTO assetDTO);
        bool DeleteAsset(int assetID);

    }
}
