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

        public AssetService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateAsset(AssetDTO assetDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAsset(int assetID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AssetDTO> GetAllAssets()
        {
            var assets = _unitOfWork.AssetRepository.GetAll();
            if (assets.Any()) return assets.ToDTOs();
            return null;
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
    }
}
