using System.Collections.Generic;
using VL.Business.Entities;

namespace VL.Business.Services.Interface
{
    public interface IVisitService
    {
        #region Visit
        VisitDTO GetVisitByID(int visitID);
        IEnumerable<VisitDTO> GetAllVisits();
        int CreateVisit(VisitDTO visitDTO);
        bool UpdateVisit(int visitID, VisitDTO visitDTO);
        bool DeleteVisit(int visitID);
        #endregion
    }
}
