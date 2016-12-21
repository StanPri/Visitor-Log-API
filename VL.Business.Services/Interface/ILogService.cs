using System.Collections.Generic;
using VL.Business.Entities;

namespace VL.Business.Services.Interface
{
    public interface ILogService
    {
        #region Log
        LogDTO GetLogByID(int logID);
        IEnumerable<LogDTO> GetAllLogs();
        int CreateLog(LogDTO logDTO);
        bool UpdateLog(int logID, LogDTO logDTO);
        bool DeleteLog(int logID);
        #endregion
    }
}
