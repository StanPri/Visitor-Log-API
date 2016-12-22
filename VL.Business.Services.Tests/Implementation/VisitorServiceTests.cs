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
    public class VisitorServiceTests
    {
        #region Variables
        private IVisitorService _visitorService;
        private IUnitOfWork _unitOfWork;
        private VisitorRepositoryFake _visitorRepository;
        private VisitorLogContext _visitorLogContext;
        #endregion

        #region Constructor - Setup
        /// <summary>
        /// Re-initializes test.
        /// </summary>
        public VisitorServiceTests()
        {
            _visitorLogContext = Substitute.For<VisitorLogContext>();
            _visitorRepository = new VisitorRepositoryFake(_visitorLogContext);
            _unitOfWork = Substitute.For<IUnitOfWork>();
            _unitOfWork.VisitorRepository.Returns(_visitorRepository);
            _visitorService = new VisitorService(_unitOfWork);
        }
        #endregion

        #region Vistor Tests
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        public void WhenGettingVisitortByID_AssertReturnedVisitor(int id)
        {
            var visitor = _visitorService.GetVisitorByID(id);
            Asset.Equals(id, visitor.ID);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void WhenGettingVisitorWithInvalidID_AssertNullReturn(int id)
        {
            var visitor = _visitorService.GetVisitorByID(id);
            Assert.Null(visitor);
        }

        [Fact]
        public void WhenGettingAllVisitors_AssertReturnedCollection()
        {
            var visitors = _visitorService.GetAllVisitors();
            Assert.Equal(DataInitializer.GetAllVisitors().Count, visitors.Count());
        }

        [Fact]
        public void WhenAllVisitorsCollectionEmpty_AssertReturnedCollectionEmpty()
        {
            //Before testing this, we need to empty what's in the repository
            _visitorRepository.GetAll().ToList().ForEach(x => _visitorRepository.Delete(x));
            var visitors = _visitorService.GetAllVisitors();
            Assert.Equal(0, visitors.Count());
        }



        #endregion

    }
}
