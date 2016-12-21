using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using VL.Business.Entities;
using VL.Business.Services.Mapper;
using VL.Data.Model;

namespace VL.Business.Services.Implementation
{
    public class CampusService : Interface.ICampusService
    {
        private readonly IUnitOfWork _unitOfWork;

        #region Constructor
        /// <summary>
        /// Public Constructor
        /// </summary>
        public CampusService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Campus
        /// <summary>
        /// Fetches Campus By ID
        /// </summary>
        /// <param name="campusID">Campus ID to retrieve</param>
        /// <returns>Campus object</returns>
        public CampusDTO GetCampusByID(int campusID)
        {
            var campus = _unitOfWork.CampusRepository.GetByID(campusID);
            if(campus != null) return campus.ToDTO();
            return null;
        }

        /// <summary>
        /// Fetches all Campuses
        /// </summary>
        /// <returns>List of Campus objects</returns>
        public IEnumerable<CampusDTO> GetAllCampuses()
        {
            var campuses = _unitOfWork.CampusRepository.GetAll();
            return campuses.ToDTOs();
        }

        /// <summary>
        /// Creates a Campus
        /// </summary>
        /// <param name="campusDTO">Campus object to insert</param>
        /// <returns>Campus ID</returns>
        public int CreateCampus(CampusDTO campusDTO)
        {
            using(var scope = new TransactionScope())
            {
                //Get DTO and assign default properties
                var c = new Campus();
                c = campusDTO.ToEntity();
                c.CreatedDate = c.ModifiedDate = System.DateTime.Now;

                //Insert data object
                _unitOfWork.CampusRepository.Insert(c);
                _unitOfWork.Save();
                scope.Complete();
                return c.ID;
            }
        }

        /// <summary>Updates an existing Campus</summary>
        /// <param name="campusID">Campus ID</param>
        /// <param name="campusDTO">Campus object</param>
        /// <returns>True or False, whether or not update was successful</returns>
        public bool UpdateCampus(int campusID, CampusDTO campusDTO)
        {
            var success = false;
            if(campusDTO != null)
            {
                using (var scope = new TransactionScope())
                {
                    var campus = _unitOfWork.CampusRepository.GetByID(campusID);
                    if(campus != null)
                    {
                        //TODO : Override properties to update and/or add transactional items
                        //campus.Reason = campusDTO.Reason;

                        //Update
                        _unitOfWork.CampusRepository.Update(campus);
                        _unitOfWork.Save();
                        scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }

        /// <summary>
        /// Deletes an existing Campus
        /// </summary>
        /// <param name="campusID">Campus ID</param>
        /// <returns>True or False, whether delete was successful</returns>
        public bool DeleteCampus(int campusID)
        {
            var success = false;
            if (campusID > 0)
            {
                using (var scope = new TransactionScope())
                {
                    var campus = _unitOfWork.CampusRepository.GetByID(campusID);
                    if (campus != null)
                    {
                        _unitOfWork.CampusRepository.Delete(campusID);
                        _unitOfWork.Save();
                        scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }
        #endregion
    }
}
