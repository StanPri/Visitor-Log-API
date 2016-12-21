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
    public class LogServiceTests
    {

        #region Variables
        private ILogService _logService;
        private IUnitOfWork _unitOfWork;
        private LogRepositoryFake _logRepository;
        private VisitorLogContext _visitorLogContext;

        #endregion

        #region Constructor - Setup
        public LogServiceTests()
        {
            _visitorLogContext = Substitute.For<VisitorLogContext>();
            _logRepository = new LogRepositoryFake(_visitorLogContext);
            _unitOfWork = Substitute.For<IUnitOfWork>();
            _unitOfWork.LogRepository.Returns(_logRepository);
            _logService = new LogService(_unitOfWork);
        }

        #endregion

        #region Log Tests
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void WhenGettingLogByID_AssertReturnedLog(int id)
        {
            var log = _logService.GetLogByID(id);
            Asset.Equals(id, log.ID);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void WhenGettingLogWithInvalidID_AssertNullReturn(int id)
        {
            var log = _logService.GetLogByID(id);
            Assert.Null(log);
        }

        [Fact]
        public void WhenGettingAllLogs_AssertReturnedCollection()
        {
            var logs = _logService.GetAllLogs();
            Assert.Equal(DataInitializer.GetAllLogs().Count, logs.Count());
        }

        [Fact]
        public void WhenAllLogsCollectionEmpty_AssertReturnedCollectionEmpty()
        {
            //Before testing this, we need to empty what's in the repository
            _logRepository.GetAll().ToList().ForEach(x => _logRepository.Delete(x));
            var logs = _logService.GetAllLogs();
            Assert.Equal(0, logs.Count());
        }

        #endregion
    }
}
