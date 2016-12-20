using System.Collections.Generic;
using VL.Business.Entities;

namespace VL.Business.Services.Interface
{
    public interface IStationService
    {
        StationDTO GetStationByID(int campusID);
        IEnumerable<StationDTO> GetAllStations();
        int CreateStation(StationDTO stationDTO);
        bool UpdateStation(int stationID, StationDTO stationDTO);
        bool DeleteStation(int stationID);
    }
}
