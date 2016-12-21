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
    public class StationServiceTests
    {
        #region Variables
        private IStationService _stationService;
        private IUnitOfWork _unitOfWork;
        private StationRepositoryFake _stationRepository;
        private VisitorLogContext _visitorLogContext;
        #endregion

        #region Constructor - Setup
        /// <summary>
        /// Re-initializes test.
        /// </summary>
        public StationServiceTests()
        {
            _visitorLogContext = Substitute.For<VisitorLogContext>();
            _stationRepository = new StationRepositoryFake(_visitorLogContext);
            _unitOfWork = Substitute.For<IUnitOfWork>();
            _unitOfWork.StationRepository.Returns(_stationRepository);
            _stationService = new StationService(_unitOfWork);
        }

        #endregion

        #region Station Tests
        [InlineData(1,2,3,4,5,6)]
        public void WhenGettingStationByID_AssertReturnedStation(int id)
        {
            var station = _stationService.GetStationByID(id);
            Asset.Equals(id, station.ID);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void WhenGettingStationWithInvalidID_AssertNullReturn(int id)
        {
            var station = _stationService.GetStationByID(id);
            Assert.Null(station);
        }

        [Fact]
        public void WhenGettingAllStations_AssertReturnedCollection()
        {
            var stations = _stationService.GetAllStations();
            Assert.Equal(DataInitializer.GetAllStations().Count, stations.Count());
        }

        [Fact]
        public void WhenAllStationsCollectionEmpty_AssertReturnedCollectionEmpty()
        {
            //Before testing this, we need to empty what's in the repository
            _stationRepository.GetAll().ToList().ForEach(x => _stationRepository.Delete(x));
            var stations = _stationService.GetAllStations();
            Assert.Equal(0, stations.Count());
        }

        #endregion
    }
}
