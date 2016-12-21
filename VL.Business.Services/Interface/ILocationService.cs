using System.Collections.Generic;
using VL.Business.Entities;

namespace VL.Business.Services.Interface
{
    public interface ILocationService
    {
        #region Location
        LocationDTO GetLocationByID(int locationID);
        IEnumerable<LocationDTO> GetAllLocations();
        int CreateLocation(LocationDTO locationDTO);
        bool UpdateLocation(int locationID, LocationDTO locationDTO);
        bool DeleteLocation(int locationID);
        IEnumerable<LocationDTO> GetLocationsByCampusID(int campusID);
        #endregion
    }

}
