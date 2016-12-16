using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using VL.Business.Entities;
using VL.Business.Services.Mapper;
using VL.Data.Model;


namespace VL.Business.Services.Implementation
{
    public class LocationService : Interface.ILocationService
    {
        private readonly IUnitOfWork _unitOfWork;

        #region Constructor
        public LocationService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        #endregion

        public int CreateLocation(LocationDTO locationDTO)
        {
            using (var scope = new TransactionScope())
            {
                //Get DTO and assign default properties
                var loc = new Location();
                loc = locationDTO.ToEntity();
                loc.CreatedDate = loc.ModifiedDate = System.DateTime.Now;

                //Insert data object
                _unitOfWork.LocationRepository.Insert(loc);
                _unitOfWork.Save();
                scope.Complete();
                return loc.ID;
            }

        }

        public bool DeleteLocation(int locationID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LocationDTO> GetAllLocations()
        {
            var locations = _unitOfWork.LocationRepository.GetAll();
            if (locations.Any()) return locations.ToDTOs();
            return null;
        }

        public LocationDTO GetLocationByID(int locationID)
        {
            var location = _unitOfWork.LocationRepository.GetByID(locationID);
            if (location != null) return location.ToDTO();
            return null;
        }

        public IEnumerable<LocationDTO> GetLocationsByCampusID(int campusID)
        {
            var locations = _unitOfWork.CampusRepository
                .GetWithInclude(c => c.ID == campusID, "CampusLocations.Location").FirstOrDefault()
                .CampusLocations.Where(cl => cl.CampusID == campusID)
                .Select(x => x.Location).ToList();
            if (locations.Any()) return locations.ToDTOs();
            return null;
        }

        public bool UpdateLocation(int locationID, LocationDTO locationDTO)
        {
            throw new NotImplementedException();
        }
    }
}
