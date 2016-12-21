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

        #endregion

        #region Unit Tests - Commented Out

        ///// <summary>
        ///// Service should return all the visitor logs
        ///// </summary>
        //[Test]
        //public void GetAllVisitorLogsTest()
        //{
        //    var visitorlogs = _campusService.GetAllCampuses();
        //    if (visitorlogs != null)
        //    {
        //        var visitorLogList =
        //            visitorlogs.Select(
        //                visitorLogEntity =>
        //                new VisitorLog { VisitID = visitorLogEntity.VisitID, Company = visitorLogEntity.Company }).
        //                ToList();
        //        var comparer = new VisitorLogComparer();
        //        CollectionAssert.AreEqual(
        //            visitorLogList.OrderBy(vl => vl, comparer),
        //            _campuses.OrderBy(vl => vl, comparer), comparer);
        //    }
        //}

        ///// <summary>
        ///// Service should return null
        ///// </summary>
        //[Test]
        //public void GetAllVisitorLogsTestForNull()
        //{
        //    _campuses.Clear();
        //    var visitorlogs = _campusService.GetAllCampuses();
        //    Assert.Null(visitorlogs);
        //    SetUpCampuses();
        //}

        ///// <summary>
        ///// Service should return visitor log if correct id is supplied
        ///// </summary>
        //[Test]
        //public void GetVisitorLogByRightIdTest()
        //{
        //    var mobileVisitorLog = _campusService.GetVisitorLogByID(2);
        //    if (mobileVisitorLog != null)
        //    {
        //        var visitorLogModel = mobileVisitorLog.ToEntity();
        //        AssertObjects.PropertyValuesAreEquals(visitorLogModel, _campuses.Find(a => a.Company.Contains("COSCOTest")));
        //    }
        //}

        ///// <summary>
        ///// Service should return null
        ///// </summary>
        //[Test]
        //public void GetVisitorLogByWrongIdTest()
        //{
        //    var product = _campusService.GetVisitorLogByID(0);
        //    Assert.Null(product);
        //}

        ///// <summary>
        ///// Add new visitor log test
        ///// </summary>
        //[Test]
        //public void AddNewVisitorLogTest()
        //{
        //    var newVisitorLog = new VisitorLogEntity()
        //    {
        //        Company = "Android Phone"
        //    };

        //    var maxVisitorLogIDBeforeAdd = _campuses.Max(a => a.VisitID);
        //    newVisitorLog.VisitID = maxVisitorLogIDBeforeAdd + 1;
        //    _campusService.CreateVisitorLog(newVisitorLog);
        //    var addedvisitorlog = new VisitorLog() { Company = newVisitorLog.Company, VisitID = newVisitorLog.VisitID };
        //    AssertObjects.PropertyValuesAreEquals(addedvisitorlog, _campuses.Last());
        //    Assert.That(maxVisitorLogIDBeforeAdd + 1, Is.EqualTo(_campuses.Last().VisitID));
        //}

        ///// <summary>
        ///// Update Visitor Log test
        ///// </summary>
        //[Test]
        //public void UpdateVisitorLogTest()
        //{
        //    var firstVisitorLog = _campuses.First();
        //    firstVisitorLog.Company = "Laptop updated";
        //    var updatedVisitorLog = new VisitorLogEntity() { Company = firstVisitorLog.Company, VisitID = firstVisitorLog.VisitID };
        //    _campusService.UpdateVisitorLog(firstVisitorLog.VisitID, updatedVisitorLog);
        //    Assert.That(firstVisitorLog.VisitID, Is.EqualTo(1)); // hasn't changed
        //    Assert.That(firstVisitorLog.Company, Is.EqualTo("Laptop updated")); // Product name changed
        //}

        ///// <summary>
        ///// Delete Visitor Log test
        ///// </summary>
        //[Test]
        //public void DeleteVisitorLogTest()
        //{
        //    int maxID = _campuses.Max(a => a.VisitID); // Before removal
        //    var lastProduct = _campuses.Last();

        //    // Remove last Product
        //    _campusService.DeleteVisitorLog(lastProduct.VisitID);
        //    Assert.That(maxID, Is.GreaterThan(_campuses.Max(a => a.VisitID))); // Max id reduced by 1
        //}

        #endregion
    }
}
