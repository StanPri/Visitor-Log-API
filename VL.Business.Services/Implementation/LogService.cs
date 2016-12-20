using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using VL.Business.Entities;
using VL.Business.Services.Mapper;
using VL.Data.Model;

namespace VL.Business.Services.Implementation
{
    public class LogService : Interface.ILogService
    {
        private readonly IUnitOfWork _unitOfWork;

        #region Constructor
        public LogService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        public int CreateLog(LogDTO logDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeleteLog(int logID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LogDTO> GetAllLogs()
        {
            var logs = _unitOfWork.LogRepository.GetAll();
            if (logs.Any()) return logs.ToDTOs();
            return null;
        }

        public LogDTO GetLogByID(int logID)
        {
            var log = _unitOfWork.LogRepository.GetByID(logID);
            if (log != null) return log.ToDTO();
            return null;
        }

        public bool UpdateLog(int logID, LogDTO logDTO)
        {
            throw new NotImplementedException();
        }
    }
}
