using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using VL.Business.Entities;
using VL.Business.Services.Mapper;
using VL.Data.Model;

namespace VL.Business.Services.Implementation
{
    public class VisitorLogService : Interface.IVisitorLogService
    {
        private readonly IUnitOfWork _unitOfWork;

        #region Constructor
        /// <summary>
        /// Public Constructor
        /// </summary>
        public VisitorLogService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        /// <summary>
        /// Fetches Visitor Log details by ID
        /// </summary>
        /// <param name="visitorlogID">Visitor Log Identifier</param>
        /// <returns>Visitor Log Entry</returns>
        public VisitorLogEntity GetVisitorLogByID(int visitorlogID)
        {
            var visitorlog = _unitOfWork.VisitorLogRepository.GetByID(visitorlogID);
            if(visitorlog != null)
            {
                return visitorlog.ToDTO();
            }
            return null;
        }

        /// <summary>
        /// Fetches all Visitor Logs
        /// </summary>
        /// <returns>List of all Visitor Logs</returns>
        public IEnumerable<VisitorLogEntity> GetAllVisitorLogs()
        {
            var visitorlogs = _unitOfWork.VisitorLogRepository.GetAll();
            if (visitorlogs.Any())
            {
                return visitorlogs.ToDTOs();
            }
            return null;
        }

        /// <summary>
        /// Creates a Visitor Log
        /// </summary>
        /// <param name="visitorLogEntity">Visitor Log to create</param>
        /// <returns>Newly created Visitor Log ID</returns>
        public int CreateVisitorLog(VisitorLogEntity visitorLogEntity)
        {
            using(var scope = new TransactionScope())
            {
                //Get data object
                var vl = new VisitorLog();
                vl = visitorLogEntity.ToEntity();

                //Insert data object
                _unitOfWork.VisitorLogRepository.Insert(vl);
                _unitOfWork.Save();
                scope.Complete();
                return vl.VisitID;
            }
        }

        /// <summary>
        /// Updates an existing Visitor Log
        /// </summary>
        /// <param name="visitorLogID">Visitor Log ID</param>
        /// <param name="visitorLogEntity">Visitor Log object</param>
        /// <returns>True or False, whether or not update was successful</returns>
        public bool UpdateVisitorLog(int visitorLogID, VisitorLogEntity visitorLogEntity)
        {
            var success = false;
            if(visitorLogEntity != null)
            {
                using (var scope = new TransactionScope())
                {
                    var visitorlog = _unitOfWork.VisitorLogRepository.GetByID(visitorLogID);
                    if(visitorlog != null)
                    {
                        //TODO : Override properties to update and/or add transactional items
                        visitorlog.Reason = visitorLogEntity.Reason;

                        //Update
                        _unitOfWork.VisitorLogRepository.Update(visitorlog);
                        _unitOfWork.Save();
                        scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }

        /// <summary>
        /// Deletes an existing Visitor Log
        /// </summary>
        /// <param name="visitorLogID">Visitor Log ID</param>
        /// <returns>True or False, whether delete was successful</returns>
        public bool DeleteVisitorLog(int visitorLogID)
        {
            var success = false;
            if (visitorLogID > 0)
            {
                using (var scope = new TransactionScope())
                {
                    var visitorlog = _unitOfWork.VisitorLogRepository.GetByID(visitorLogID);
                    if (visitorlog != null)
                    {
                        _unitOfWork.VisitorLogRepository.Delete(visitorLogID);
                        _unitOfWork.Save();
                        scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }
    }
}
