using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using VL.Business.Entities;
using VL.Business.Services.Mapper;
using VL.Data.Model;

namespace VL.Business.Services.Implementation
{
    public class AssetService : Interface.IAssetService
    {
        private readonly IUnitOfWork _unitOfWork;

        #region Constructor
        public AssetService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Asset
        public int CreateAsset(AssetDTO assetDTO)
        {
            using (var scope = new TransactionScope())
            {
                //Get DTO and assign default properties
                var a = new Asset();
                a = assetDTO.ToEntity();
                a.CreateDate = a.ModifiedDate = System.DateTime.Now;

                //Insert data object
                _unitOfWork.AssetRepository.Insert(a);
                _unitOfWork.Save();
                scope.Complete();
                return a.ID;
            }

        }
        public bool DeleteAsset(int assetID)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<AssetDTO> GetAllAssets()
        {
            var assets = _unitOfWork.AssetRepository.GetAll();
            return assets.ToDTOs();
        }
        public AssetDTO GetAssetByID(int assetID)
        {
            var asset = _unitOfWork.AssetRepository.GetByID(assetID);
            if (asset != null) return asset.ToDTO();
            return null;
        }
        public bool UpdateAsset(int assetID, AssetDTO assetDTO)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region AssetHistory
        public IEnumerable<AssetHistoryDTO> GetAssetHistoryByAssetID(int assetID)
        {
            var assetHistory = _unitOfWork.AssetHistoryRepository.GetMany(x => x.AssetID == assetID).ToList();
            return assetHistory.ToDTOs();
        }

        #endregion

        #region AssetType
        public int CreateAssetType(AssetTypeDTO assetTypeDTO)
        {
            using (var scope = new TransactionScope())
            {
                //Get DTO and assign default properties
                var assType = new AssetType();
                assType = assetTypeDTO.ToEntity();
                assType.CreatedDate = assType.ModifiedDate = System.DateTime.Now;

                //Insert data object
                _unitOfWork.AssetTypeRepository.Insert(assType);
                _unitOfWork.Save();
                scope.Complete();
                return assType.ID;
            }
        }
        public bool DeleteAssetType(int assetTypeID)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<AssetTypeDTO> GetAllAssetTypes()
        {
            var assetTypes = _unitOfWork.AssetTypeRepository.GetAll();
            return assetTypes.ToDTOs();
        }
        public AssetTypeDTO GetAssetTypeByID(int assetTypeID)
        {
            var assetType = _unitOfWork.AssetTypeRepository.GetByID(assetTypeID);
            if (assetType != null) return assetType.ToDTO();
            return null;
        }
        public bool UpdateAssetType(int assetTypeID, AssetTypeDTO assetTypeDTO)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region AssetTypeHistory
        public IEnumerable<AssetTypeHistoryDTO> GetAssetTypeHistoryByAssetTypeID(int assetTypeID)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
