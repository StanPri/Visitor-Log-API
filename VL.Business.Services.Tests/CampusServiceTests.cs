using Moq;
using NUnit.Framework;
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

namespace VL.Business.Services.Tests
{
    public class CampusServiceTests
    {

        #region Variables

        private ICampusService _campusService;
        private IUnitOfWork _unitOfWork;
        private List<Campus> _campuses;
        private GenericRepository<Campus> _campusRepository;
        private VisitorLogContext _visitorLogContext;
        #endregion

        #region Test fixture setup

        /// <summary>
        /// Initial setup for tests
        /// </summary>
        [TestFixtureSetUp]
        public void Setup()
        {
            _campuses = SetUpCampuses();
        }

        #endregion

        #region Setup

        /// <summary>
        /// Re-initializes test.
        /// </summary>
        [SetUp]
        public void ReInitializeTest()
        {
            _campuses = SetUpCampuses();
            _visitorLogContext = new Mock<VisitorLogContext>().Object;
            _campusRepository = SetUpCampusRepository();
            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.SetupGet(s => s.CampusRepository).Returns(_campusRepository);
            _unitOfWork = unitOfWork.Object;
            _campusService = new CampusService(_unitOfWork);
        }

        #endregion

        #region Private member methods

        /// <summary>
        /// Setup dummy repository
        /// </summary>
        /// <returns></returns>
        private GenericRepository<Campus> SetUpCampusRepository()
        {
            // Initialise repository
            var mockRepo = new Mock<GenericRepository<Campus>>(MockBehavior.Default, _visitorLogContext);

            // Setup mocking behavior
            mockRepo
                .Setup(p => p.GetAll()).Returns(_campuses);
            mockRepo
                .Setup(p => p.GetByID(It.IsAny<int>()))
                .Returns(new Func<int, Campus>(id => _campuses.Find(p => p.ID.Equals(id))));

            mockRepo
                .Setup(p => p.Insert((It.IsAny<Campus>())))
                .Callback(new Action<Campus>(newCampus =>
                {
                    dynamic maxCampusID = _campuses.Last().ID;
                    dynamic nextCampusID = maxCampusID + 1;
                    newCampus.ID = nextCampusID;
                    _campuses.Add(newCampus);
                }));

            mockRepo
                .Setup(p => p.Update(It.IsAny<Campus>()))
                .Callback(new Action<Campus>(camp =>
                {
                    var oldCampus = _campuses.Find(a => a.ID == camp.ID);
                    oldCampus = camp;
                }));

            mockRepo
                .Setup(p => p.Delete(It.IsAny<Campus>()))
                .Callback(new Action<Campus>(camp =>
                {
                    var campToRemove =
                        _campuses.Find(a => a.ID == camp.ID);

                    if (campToRemove != null)
                        _campuses.Remove(campToRemove);
                }));

            // Return mock implementation object
            return mockRepo.Object;
        }

        /// <summary>
        /// Setup dummy Visitor Log data
        /// </summary>
        /// <returns></returns>
        private static List<Campus> SetUpCampuses()
        {
            var campusID = new int();
            var campuses = DataInitializer.GetAllCampuses();
            //foreach (Campus camp in campuses)
            //    camp.VisitID = ++campusID;
            return campuses;
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

        #region Tear Down

        /// <summary>
        /// Tears down each test data
        /// </summary>
        [TearDown]
        public void DisposeTest()
        {
            _campusService = null;
            _unitOfWork = null;
            _campusRepository = null;
            if (_visitorLogContext != null)
                _visitorLogContext.Dispose();
            _campuses = null;
        }

        #endregion

        #region TestFixture TearDown.

        /// <summary>
        /// TestFixture teardown
        /// </summary>
        [TestFixtureTearDown]
        public void DisposeAllObjects()
        {
            _campuses = null;
        }

        #endregion


    }
}
