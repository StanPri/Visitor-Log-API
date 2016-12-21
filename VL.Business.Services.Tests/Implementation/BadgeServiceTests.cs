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
    public class BadgeServiceTests
    {

        #region Variables
        private IBadgeService _badgeService;
        private IUnitOfWork _unitOfWork;
        private BadgeRepositoryFake _badgeRepository;
        private BadgeTypeRepositoryFake _badgeTypeRepository;
        private VisitorLogContext _visitorLogContext;
        #endregion

        #region Constructor - Setup
        /// <summary>
        /// Re-initializes test.
        /// </summary>
        public BadgeServiceTests()
        {
            _visitorLogContext = Substitute.For<VisitorLogContext>();
            _badgeRepository = new BadgeRepositoryFake(_visitorLogContext);
            _badgeTypeRepository = new BadgeTypeRepositoryFake(_visitorLogContext);
            _unitOfWork = Substitute.For<IUnitOfWork>();
            _unitOfWork.BadgeRepository.Returns(_badgeRepository);
            _unitOfWork.BadgeTypeRepository.Returns(_badgeTypeRepository);
            _badgeService = new BadgeService(_unitOfWork);
        }
        #endregion

        #region Badge Tests
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void WhenGettingBadgeByID_AssertReturnedBadge(int id)
        {
            var badge = _badgeService.GetBadgeByID(id);
            Asset.Equals(id, badge.ID);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void WhenGettingBadgeWithInvalidID_AssertNullReturn(int id)
        {
            var badge = _badgeService.GetBadgeByID(id);
            Assert.Null(badge);
        }

        [Fact]
        public void WhenGettingAllBadges_AssertReturnedCollection()
        {
            var badges = _badgeService.GetAllBadges();
            Assert.Equal(DataInitializer.GetAllBadges().Count, badges.Count());
        }

        [Fact]
        public void WhenAllBadgesCollectionEmpty_AssertReturnedCollectionEmpty()
        {
            //Before testing this, we need to empty what's in the repository
            _badgeRepository.GetAll().ToList().ForEach(x => _badgeRepository.Delete(x));
            var badges = _badgeService.GetAllBadges();
            Assert.Equal(0, badges.Count());
        }

        #endregion

        #region BadgeType Tests
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void WhenGettingBadgeTypeByID_AssertReturnedBadgeType(int id)
        {
            var badgeType = _badgeService.GetBadgeTypeByID(id);
            Asset.Equals(id, badgeType.ID);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void WhenGettingBadgeTypetWithInvalidID_AssertNullReturn(int id)
        {
            var badgeType = _badgeService.GetBadgeTypeByID(id);
            Assert.Null(badgeType);
        }

        [Fact]
        public void WhenGettingAllBadgeTypes_AssertReturnedCollection()
        {
            var badgeTypes = _badgeService.GetAllBadgeTypes();
            Assert.Equal(DataInitializer.GetAllBadgeTypes().Count, badgeTypes.Count());
        }

        [Fact]
        public void WhenAllBadgeTypesCollectionEmpty_AssertReturnedCollectionEmpty()
        {
            //Before testing this, we need to empty what's in the repository
            _badgeTypeRepository.GetAll().ToList().ForEach(x => _badgeTypeRepository.Delete(x));
            var badgeTypes = _badgeService.GetAllBadgeTypes();
            Assert.Equal(0, badgeTypes.Count());
        }
        #endregion
    }
}
