using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using VL.Business.Entities;
using VL.Business.Services.Interface;
using VL.Business.Services.Mapper;
using VL.Data.Model;

namespace VL.Business.Services.Implementation
{
    public class VisitorService : Interface.IVisitorService
    {
        private readonly IUnitOfWork _unitOfWork;

        #region Constructor
        public VisitorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion

        public int CreateVisitor(VisitorDTO visitorDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeleteVisitor(int visitorID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<VisitorDTO> GetAllVisitors()
        {
            var visitors = _unitOfWork.VisitorRepository.GetAll();
            if (visitors.Any()) return visitors.ToDTOs();
            return null;
        }

        public VisitorDTO GetVisitorByID(int visitorID)
        {
            var visitor = _unitOfWork.VisitorRepository.GetByID(visitorID);
            if (visitor != null) return visitor.ToDTO();
            return null;
        }

        public bool UpdateVisitor(int visitorID, VisitorDTO visitorDTO)
        {
            throw new NotImplementedException();
        }
    }
}
