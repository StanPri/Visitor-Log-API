using System.Collections.Generic;
using VL.Business.Entities;

namespace VL.Business.Services.Interface
{
    public interface IVisitorLogService
    {
        VisitorLogEntity GetVisitorLogByID(int visitorlogID);
        IEnumerable<VisitorLogEntity> GetAllVisitorLogs();
        int CreateVisitorLog(VisitorLogEntity visitorLogEntity);
        bool UpdateVisitorLog(int visitorLogID, VisitorLogEntity visitorLogEntity);
        bool DeleteVisitorLog(int visitorLogID);

    }
}
