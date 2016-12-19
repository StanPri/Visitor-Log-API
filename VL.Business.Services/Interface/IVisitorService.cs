using System.Collections.Generic;
using VL.Business.Entities;

namespace VL.Business.Services.Interface
{
    public interface IVisitorService
    {
        VisitorDTO GetVisitorByID(int visitorID);
        IEnumerable<CampusDTO> GetAllVisitors();
        int CreateVisitor(VisitorDTO visitorDTO);
        bool UpdateVisitor(int visitorID, VisitorDTO  visitorDTO);
        bool DeleteVisitor(int visitorID);
    }
}
