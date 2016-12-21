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

namespace VL.Business.Services.Tests.Implementation
{
    public class LocationServiceTests
    {
        #region Variables
        private ILocationService _locationService;
        private IUnitOfWork _unitOfWork;
        private LocationRepositoryFake _locationRepository;
        private VisitorLogContext _visitorLogContext;
        #endregion

        #region Constructor - Setup
        /// <summary>
        /// Re-initializes test.
        /// </summary>
        public LocationServiceTests()
        {
            _visitorLogContext = Substitute.For<VisitorLogContext>();
            _locationRepository = new LocationRepositoryFake(_visitorLogContext);
            _unitOfWork = Substitute.For<IUnitOfWork>();
            _unitOfWork.LocationRepository.Returns(_locationRepository);
            _locationService = new LocationService(_unitOfWork);
        }
        #endregion

        #region Location Tests
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void WhenGettingLocationByID_AssertReturnedLocation(int id)
        {
            var location = _locationService.GetLocationByID(id);
            Asset.Equals(id, location.ID);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void WhenGettingLocationWithInvalidID_AssertNullReturn(int id)
        {
            var location = _locationService.GetLocationByID(id);
            Assert.Null(location);
        }

        [Fact]
        public void WhenGettingAllLocations_AssertReturnedCollection()
        {
            var locations = _locationService.GetAllLocations();
            Assert.Equal(DataInitializer.GetAllLocations().Count, locations.Count());
        }

        [Fact]
        public void WhenAllLocationsCollectionEmpty_AssertReturnedCollectionEmpty()
        {
            //Before testing this, we need to empty what's in the repository
            _locationRepository.GetAll().ToList().ForEach(x => _locationRepository.Delete(x));
            var locations = _locationService.GetAllLocations();
            Assert.Equal(0, locations.Count());
        }



        #endregion
    }
}
