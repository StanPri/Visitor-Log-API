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
    public class VisitServiceTests
    {
        #region Variables
        private IVisitService _visitService;
        private IUnitOfWork _unitOfWork;
        private VisitRepositoryFake _visitRepository;
        private VisitorLogContext _visitorLogContext;
        #endregion

        #region Constructor - Setup
        /// <summary>
        /// Re-initializes test.
        /// </summary>
        public VisitServiceTests()
        {
            _visitorLogContext = Substitute.For<VisitorLogContext>();
            _visitRepository = new VisitRepositoryFake(_visitorLogContext);
            _unitOfWork = Substitute.For<IUnitOfWork>();
            _unitOfWork.VisitRepository.Returns(_visitRepository);
            _visitService = new VisitService(_unitOfWork);
        }
        #endregion

        #region Visit Tests
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void WhenGettingVisitByID_AssertReturnedVisit(int id)
        {
            var visit = _visitService.GetVisitByID(id);
            Asset.Equals(id, visit.ID);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void WhenGettingVisitWithInvalidID_AssertNullReturn(int id)
        {
            var visit = _visitService.GetVisitByID(id);
            Assert.Null(visit);
        }

        [Fact]
        public void WhenGettingAllVisits_AssertReturnedCollection()
        {
            var visits = _visitService.GetAllVisits();
            Assert.Equal(DataInitializer.GetAllVisits().Count, visits.Count());
        }

        [Fact]
        public void WhenAllVisitsCollectionEmpty_AssertReturnedCollectionEmpty()
        {
            //Before testing this, we need to empty what's in the repository
            _visitRepository.GetAll().ToList().ForEach(x => _visitRepository.Delete(x));
            var visits = _visitService.GetAllVisits();
            Assert.Equal(0, visits.Count());
        }
        #endregion
    }
}
