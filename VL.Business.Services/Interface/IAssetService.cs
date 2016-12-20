using System.Collections.Generic;
using VL.Business.Entities;


namespace VL.Business.Services.Interface
{
    public interface IAssetService
    {
        #region Asset

        AssetDTO GetAssetByID(int assetID);
        IEnumerable<AssetDTO> GetAllAssets();
        int CreateAsset(AssetDTO assetDTO);
        bool UpdateAsset(int assetID, AssetDTO assetDTO);
        bool DeleteAsset(int assetID);

        #endregion

        #region AssetHistory
        IEnumerable<AssetHistoryDTO> GetAssetHistoryByAssetID(int assetID);

        #endregion

        #region AssetType
        AssetTypeDTO GetAssetTypeByID(int assetTypeID);
        IEnumerable<AssetTypeDTO> GetAllAssetTypes();
        int CreateAssetType(AssetTypeDTO assetTypeDTO);
        bool UpdateAssetType(int assetTypeID, AssetTypeDTO assetTypeDTO);
        bool DeleteAssetType(int assetTypeID);

        #endregion

        #region AssetTypeHistory
        AssetTypeHistoryDTO GetAssetTypeHistoryByAssetTypeID(int assetTypeID);
        #endregion
    }
}
