using System.Collections.Generic;
using VL.Business.Entities;

namespace VL.Business.Services.Interface
{
    public interface IVisitorService
    {
        #region Visitor
        VisitorDTO GetVisitorByID(int visitorID);
        IEnumerable<VisitorDTO> GetAllVisitors();

        int CreateVisitor(VisitorDTO visitorDTO);
        bool UpdateVisitor(int visitorID, VisitorDTO visitorDTO);
        bool DeleteVisitor(int visitorID);
        #endregion
    }
}
