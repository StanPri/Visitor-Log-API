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
    public class VisitorLogServiceTests
    {

        #region Variables

        private IVisitorLogService _visitorLogService;
        private IUnitOfWork _unitOfWork;
        private List<VisitorLog> _visitorLogs;
        private GenericRepository<VisitorLog> _visitorLogRepository;
        private VisitorLogContext _visitorLogContext;
        #endregion

        #region Test fixture setup

        /// <summary>
        /// Initial setup for tests
        /// </summary>
        [TestFixtureSetUp]
        public void Setup()
        {
            _visitorLogs = SetUpVisitorLogs();
        }

        #endregion

        #region Setup

        /// <summary>
        /// Re-initializes test.
        /// </summary>
        [SetUp]
        public void ReInitializeTest()
        {
            _visitorLogs = SetUpVisitorLogs();
            _visitorLogContext = new Mock<VisitorLogContext>().Object;
            _visitorLogRepository = SetUpVisitorLogRepository();
            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.SetupGet(s => s.VisitorLogRepository).Returns(_visitorLogRepository);
            _unitOfWork = unitOfWork.Object;
            _visitorLogService = new VisitorLogService(_unitOfWork);
        }

        #endregion

        #region Private member methods

        /// <summary>
        /// Setup dummy repository
        /// </summary>
        /// <returns></returns>
        private GenericRepository<VisitorLog> SetUpVisitorLogRepository()
        {
            // Initialise repository
            var mockRepo = new Mock<GenericRepository<VisitorLog>>(MockBehavior.Default, _visitorLogContext);

            // Setup mocking behavior
            mockRepo
                .Setup(p => p.GetAll()).Returns(_visitorLogs);
            mockRepo
                .Setup(p => p.GetByID(It.IsAny<int>()))
                .Returns(new Func<int, VisitorLog>(id => _visitorLogs.Find(p => p.VisitID.Equals(id))));

            mockRepo
                .Setup(p => p.Insert((It.IsAny<VisitorLog>())))
                .Callback(new Action<VisitorLog>(newVisitorLog =>
                {
                    dynamic maxVisitID = _visitorLogs.Last().VisitID;
                    dynamic nextVisitID = maxVisitID + 1;
                    newVisitorLog.VisitID = nextVisitID;
                    _visitorLogs.Add(newVisitorLog);
                }));

            mockRepo
                .Setup(p => p.Update(It.IsAny<VisitorLog>()))
                .Callback(new Action<VisitorLog>(vl =>
                {
                    var oldVisitorLog = _visitorLogs.Find(a => a.VisitID == vl.VisitID);
                    oldVisitorLog = vl;
                }));

            mockRepo
                .Setup(p => p.Delete(It.IsAny<VisitorLog>()))
                .Callback(new Action<VisitorLog>(vl =>
                {
                    var visitorLogToRemove =
                        _visitorLogs.Find(a => a.VisitID == vl.VisitID);

                    if (visitorLogToRemove != null)
                        _visitorLogs.Remove(visitorLogToRemove);
                }));

            // Return mock implementation object
            return mockRepo.Object;
        }

        /// <summary>
        /// Setup dummy Visitor Log data
        /// </summary>
        /// <returns></returns>
        private static List<VisitorLog> SetUpVisitorLogs()
        {
            var visitorLogId = new int();
            var visitorlogs = DataInitializer.GetAllVisitorLogs();
            foreach (VisitorLog vl in visitorlogs)
                vl.VisitID = ++visitorLogId;
            return visitorlogs;
        }

        #endregion

        #region Unit Tests

        /// <summary>
        /// Service should return all the visitor logs
        /// </summary>
        [Test]
        public void GetAllVisitorLogsTest()
        {
            var visitorlogs = _visitorLogService.GetAllVisitorLogs();
            if (visitorlogs != null)
            {
                var visitorLogList =
                    visitorlogs.Select(
                        visitorLogEntity =>
                        new VisitorLog { VisitID = visitorLogEntity.VisitID, Company = visitorLogEntity.Company }).
                        ToList();
                var comparer = new VisitorLogComparer();
                CollectionAssert.AreEqual(
                    visitorLogList.OrderBy(vl => vl, comparer),
                    _visitorLogs.OrderBy(vl => vl, comparer), comparer);
            }
        }

        /// <summary>
        /// Service should return null
        /// </summary>
        [Test]
        public void GetAllVisitorLogsTestForNull()
        {
            _visitorLogs.Clear();
            var visitorlogs = _visitorLogService.GetAllVisitorLogs();
            Assert.Null(visitorlogs);
            SetUpVisitorLogs();
        }

        /// <summary>
        /// Service should return visitor log if correct id is supplied
        /// </summary>
        [Test]
        public void GetVisitorLogByRightIdTest()
        {
            var mobileVisitorLog = _visitorLogService.GetVisitorLogByID(2);
            if (mobileVisitorLog != null)
            {
                var visitorLogModel = mobileVisitorLog.ToEntity();
                AssertObjects.PropertyValuesAreEquals(visitorLogModel, _visitorLogs.Find(a => a.Company.Contains("COSCOTest")));
            }
        }

        /// <summary>
        /// Service should return null
        /// </summary>
        [Test]
        public void GetVisitorLogByWrongIdTest()
        {
            var product = _visitorLogService.GetVisitorLogByID(0);
            Assert.Null(product);
        }

        /// <summary>
        /// Add new visitor log test
        /// </summary>
        [Test]
        public void AddNewVisitorLogTest()
        {
            var newVisitorLog = new VisitorLogEntity()
            {
                Company = "Android Phone"
            };

            var maxVisitorLogIDBeforeAdd = _visitorLogs.Max(a => a.VisitID);
            newVisitorLog.VisitID = maxVisitorLogIDBeforeAdd + 1;
            _visitorLogService.CreateVisitorLog(newVisitorLog);
            var addedvisitorlog = new VisitorLog() { Company = newVisitorLog.Company, VisitID = newVisitorLog.VisitID };
            AssertObjects.PropertyValuesAreEquals(addedvisitorlog, _visitorLogs.Last());
            Assert.That(maxVisitorLogIDBeforeAdd + 1, Is.EqualTo(_visitorLogs.Last().VisitID));
        }

        /// <summary>
        /// Update Visitor Log test
        /// </summary>
        [Test]
        public void UpdateVisitorLogTest()
        {
            var firstVisitorLog = _visitorLogs.First();
            firstVisitorLog.Company = "Laptop updated";
            var updatedVisitorLog = new VisitorLogEntity() { Company = firstVisitorLog.Company, VisitID = firstVisitorLog.VisitID };
            _visitorLogService.UpdateVisitorLog(firstVisitorLog.VisitID, updatedVisitorLog);
            Assert.That(firstVisitorLog.VisitID, Is.EqualTo(1)); // hasn't changed
            Assert.That(firstVisitorLog.Company, Is.EqualTo("Laptop updated")); // Product name changed
        }

        /// <summary>
        /// Delete Visitor Log test
        /// </summary>
        [Test]
        public void DeleteVisitorLogTest()
        {
            int maxID = _visitorLogs.Max(a => a.VisitID); // Before removal
            var lastProduct = _visitorLogs.Last();

            // Remove last Product
            _visitorLogService.DeleteVisitorLog(lastProduct.VisitID);
            Assert.That(maxID, Is.GreaterThan(_visitorLogs.Max(a => a.VisitID))); // Max id reduced by 1
        }

        #endregion


        #region Tear Down

        /// <summary>
        /// Tears down each test data
        /// </summary>
        [TearDown]
        public void DisposeTest()
        {
            _visitorLogService = null;
            _unitOfWork = null;
            _visitorLogRepository = null;
            if (_visitorLogContext != null)
                _visitorLogContext.Dispose();
            _visitorLogs = null;
        }

        #endregion

        #region TestFixture TearDown.

        /// <summary>
        /// TestFixture teardown
        /// </summary>
        [TestFixtureTearDown]
        public void DisposeAllObjects()
        {
            _visitorLogs = null;
        }

        #endregion


    }
}
