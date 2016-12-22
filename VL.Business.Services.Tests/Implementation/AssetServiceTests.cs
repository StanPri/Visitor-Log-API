using System;
using System.Collections.Generic;
using System.Linq;
using VL.Business.Services.Implementation;
using VL.Business.Services.Interface;
using VL.Data.Model;
using VL.Data.Model.GenericRepository;
using VL.Tests.Helpers;
using VL.Business.Services.Mapper;
using VL.Business.Entities;

using NSubstitute;
using VL.Business.Services.Tests.Fakes.VL.Data.Model;
using Xunit;

namespace VL.Business.Services.Tests
{
    public class AssetServiceTests
    {
        #region Variables
        private IAssetService _assetService;
        private IUnitOfWork _unitOfWork;
        private AssetRepositoryFake _assetRepository;
        private AssetTypeRepositoryFake _assetTypeRepository;
        private VisitorLogContext _visitorLogContext;
        #endregion

        #region Constructor - Setup
        /// <summary>
        /// Re-initializes test.
        /// </summary>
        public AssetServiceTests()
        {
            _visitorLogContext = Substitute.For<VisitorLogContext>();
            _assetRepository = new AssetRepositoryFake(_visitorLogContext);
            _assetTypeRepository = new AssetTypeRepositoryFake(_visitorLogContext);
            _unitOfWork = Substitute.For<IUnitOfWork>();
            _unitOfWork.AssetRepository.Returns(_assetRepository);
            _unitOfWork.AssetTypeRepository.Returns(_assetTypeRepository);
            _assetService = new AssetService(_unitOfWork);
        }

        #endregion

        #region Asset Tests
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void WhenGettingAssetByID_AssertReturnedAsset(int id)
        {
            var asset = _assetService.GetAssetByID(id);
            Asset.Equals(id, asset.ID);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void WhenGettingAssetWithInvalidID_AssertNullReturn(int id)
        {
            var asset = _assetService.GetAssetByID(id);
            Assert.Null(asset);
        }

        [Fact]
        public void WhenGettingAllAssets_AssertReturnedCollection()
        {
            var assets = _assetService.GetAllAssets();
            Assert.Equal(DataInitializer.GetAllAssets().Count, assets.Count());
        }

        [Fact]
        public void WhenAllAssetsCollectionEmpty_AssertReturnedCollectionEmpty()
        {
            //Before testing this, we need to empty what's in the repository
            _assetRepository.GetAll().ToList().ForEach(x => _assetRepository.Delete(x));
            var assets = _assetService.GetAllAssets();
            Assert.Equal(0, assets.Count());
        }

        #endregion

        #region AssetType Tests
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void WhenGettingAssetTypeByID_AssertReturnedAssetType(int id)
        {
            var assettype = _assetService.GetAssetTypeByID(id);
            Asset.Equals(id, assettype.ID);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void WhenGettingAssetTypetWithInvalidID_AssertNullReturn(int id)
        {
            var assettype = _assetService.GetAssetTypeByID(id);
            Assert.Null(assettype);
        }

        [Fact]
        public void WhenGettingAllAssetTypes_AssertReturnedCollection()
        {
            var assettypes = _assetService.GetAllAssetTypes();
            Assert.Equal(DataInitializer.GetAllAssetTypes().Count, assettypes.Count());
        }

        [Fact]
        public void WhenAllAssetTypesCollectionEmpty_AssertReturnedCollectionEmpty()
        {
            //Before testing this, we need to empty what's in the repository
            _assetTypeRepository.GetAll().ToList().ForEach(x => _assetTypeRepository.Delete(x));
            var assettypes = _assetService.GetAllAssetTypes();
            Assert.Equal(0, assettypes.Count());
        }
        #endregion
    }
}
