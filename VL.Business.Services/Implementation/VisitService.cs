using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using VL.Business.Entities;
using VL.Business.Services.Mapper;
using VL.Data.Model;

namespace VL.Business.Services.Implementation
{
    public class VisitService : Interface.IVisitService
    {
        private readonly IUnitOfWork _unitOfWork;

        #region Constructor
        public VisitService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Visit
        public int CreateVisit(VisitDTO visitDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeleteVisit(int visitID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VisitDTO> GetAllVisits()
        {
            var visits = _unitOfWork.VisitRepository.GetAll();
            if (visits.Any()) return visits.ToDTOs();
            return null;
        }

        public VisitDTO GetVisitByID(int visitID)
        {
            var visit = _unitOfWork.VisitRepository.GetByID(visitID);
            if (visit != null) return visit.ToDTO();
            return null;
        }

        public bool UpdateVisit(int visitID, VisitDTO visitDTO)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
