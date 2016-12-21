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
    public class BadgeService : Interface.IBadgeService
    {
        private readonly IUnitOfWork _unitOfWork;

        #region Badge

        public BadgeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public int CreateBadge(BadgeDTO badgeDTO)
        {
            throw new NotImplementedException();
        }
        public bool DeleteBadge(int badgeID)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<BadgeDTO> GetAllBadges()
        {
            var badges = _unitOfWork.BadgeRepository.GetAll();
            return badges.ToDTOs();
        }
        public BadgeDTO GetBadgeByID(int badgeID)
        {
            var badge = _unitOfWork.BadgeRepository.GetByID(badgeID);
            if (badge != null) return badge.ToDTO();
            return null;
        }
        public bool UpdateBadge(int badgeID, BadgeDTO badgeDTO)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region BadgeHistory
        public IEnumerable<BadgeHistoryDTO> GetBadgeHistoryByBadgeID(int badgeID)
        {
            var badgeHistory = _unitOfWork.BadgeHistoryRepository.GetMany(x => x.BadgeID == badgeID).ToList();
            return badgeHistory.ToDTOs();
        }

        #endregion

        #region BadgeType
        public int CreateBadgeType(BadgeTypeDTO badgeTypeDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeleteBadgeType(int bageTypeID)
        {
            throw new NotImplementedException();
        }

        public BadgeTypeDTO GetBadgeTypeByID(int badgeTypeID)
        {
            var badgeType = _unitOfWork.BadgeTypeRepository.GetByID(badgeTypeID);
            if (badgeType != null) return badgeType.ToDTO();
            return null;
        }

        public bool UpdateBadgeType(int badgeTypeID, BadgeTypeDTO badgeTypeDTO)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<BadgeTypeDTO> GetAllBadgeTypes()
        {
            var badgeTypes = _unitOfWork.BadgeTypeRepository.GetAll();
            return badgeTypes.ToDTOs();
        }
        #endregion

        #region BadgeTypeHistory
        public IEnumerable<BadgeTypeHistoryDTO> GetBadgeTypeHistoryByBadgeTypeID(int badgeID)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
