using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using VL.Business.Entities;
using VL.Business.Services.Mapper;
using VL.Data.Model;

namespace VL.Business.Services.Implementation
{
    public class StationService : Interface.IStationService
    {
        private readonly IUnitOfWork _unitOfWork;

        #region Constructor
        public StationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        public int CreateStation(StationDTO stationDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStation(int stationID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StationDTO> GetAllStations()
        {
            var stations = _unitOfWork.StationRepository.GetAll();
            if (stations.Any()) return stations.ToDTOs();
            return null;
        }

        public StationDTO GetStationByID(int stationID)
        {
            var station = _unitOfWork.StationRepository.GetByID(stationID);
            if (station != null) return station.ToDTO();
            return null;
        }

        public bool UpdateStation(int stationID, StationDTO stationDTO)
        {
            throw new NotImplementedException();
        }
    }
}
