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
    /// <summary>
    /// Implements unit tests for <see cref="VL.Business.Services.Implementation.CampusService"/>
    /// </summary>
    public class CampusServiceTests
    {
        #region Variables

        private ICampusService _campusService;
        private IUnitOfWork _unitOfWork;
        private CampusRepositoryFake _campusRepository;
        private VisitorLogContext _visitorLogContext;
        #endregion

        #region Setup

        /// <summary>
        /// Re-initializes test.
        /// </summary>
        public CampusServiceTests()
        {
            _visitorLogContext = Substitute.For<VisitorLogContext>();
            _campusRepository = new CampusRepositoryFake(_visitorLogContext);
            _unitOfWork = Substitute.For<IUnitOfWork>();
            _unitOfWork.CampusRepository.Returns(_campusRepository);
            _campusService = new CampusService(_unitOfWork);
        }

        #endregion

        #region Tests

        [Theory]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(8)]
        public void WhenGettingCampusById_AssertReturnedCampus(int id)
        {
            var campus = _campusService.GetCampusByID(id);
            Assert.Equal(id, campus.ID);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        [InlineData(9)]//Note: 8 is the highest ID in the list, so we're testing the edge case if grabbing the one after it. If that ever changes, this test is fail, so rememeber to update this 9
        public void WhenGettingCampusWithInvalidId_AssertNullReturn(int id)
        {
            var campus = _campusService.GetCampusByID(id);
            Assert.Null(campus);
        }

        [Fact]
        public void WhenGettingAllCampuses_AssertReturnedCollection()
        {
            var campuses = _campusService.GetAllCampuses();
            Assert.Equal(DataInitializer.GetAllCampuses().Count, campuses.Count());
        }

        [Fact]
        public void WhenAllCampusesCollectionEmpty_AssertReturnedCollectionEmpty()
        {
            //Before testing this, we need to empty what's in the repository
            _campusRepository.GetAll().ToList().ForEach(x => _campusRepository.Delete(x));

            var campuses = _campusService.GetAllCampuses();
            Assert.Equal(0, campuses.Count());
        }

        [Fact]
        public void WhenCreatingCampus_AssertCampusAdded()
        {
            int lastCampusId = GetLastCampusId();
            var newCampus = new CampusDTO { Name = "New Test Campus"};
            var newCampusId = _campusService.CreateCampus(newCampus);
            Assert.Equal(lastCampusId + 1, newCampusId);
        }
        
        [Fact]
        public void WhenCreatingInvalidCampus_AssertExceptionThrown()
        {
            CampusDTO newCampus = null;
            Assert.Throws<NullReferenceException>(() => _campusService.CreateCampus(newCampus));
        }

        [Fact]
        public void kjnksjndkjsnd()
        {
            var originalCampus = new CampusDTO { Name = "Original Campus" };

            //_campus
            //var updatedCampus = new CampusDTO { Name = "New Campus" };
            //_campusService.UpdateCampus(100, updatedCampus);
        }

        #endregion

        #region Utilities

        private int GetLastCampusId()
        {
            return _campusService.GetAllCampuses()
                                    .Select(x => x.ID)
                                    .OrderBy(x => x)
                                    .Last();
        }

        #endregion
    }
}
