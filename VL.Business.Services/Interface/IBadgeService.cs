using System.Collections.Generic;
using VL.Business.Entities;

namespace VL.Business.Services.Interface
{
    public interface IBadgeService
    {
        BadgeDTO GetBadgeByID(int badgeID);
        IEnumerable<BadgeDTO> GetAllBadges();
        int CreateBadge(BadgeDTO badgeDTO);
        bool UpdateBadge(int badgeID, BadgeDTO badgeDTO);
        bool DeleteBadge(int badgeID);

    }
}
