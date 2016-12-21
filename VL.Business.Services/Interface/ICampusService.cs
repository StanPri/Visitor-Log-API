using System.Collections.Generic;
using VL.Business.Entities;

namespace VL.Business.Services.Interface
{
    public interface ICampusService
    {
        #region Campus
        CampusDTO GetCampusByID(int campusID);
        IEnumerable<CampusDTO> GetAllCampuses();
        int CreateCampus(CampusDTO campusDTO);
        bool UpdateCampus(int campusID, CampusDTO campusDTO);
        bool DeleteCampus(int campusID);
        #endregion
    }
}
