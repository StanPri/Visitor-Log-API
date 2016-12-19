using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using VL.Business.Entities;
using VL.Business.Services.Mapper;
using VL.Data.Model;

namespace VL.Business.Services.Implementation
{
    public class BadgeService : Interface.IBadgeService
    {
        private readonly IUnitOfWork _unitOfWork;

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
            if (badges.Any()) return badges.ToDTOs();
            return null;
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
    }
}
