using System.Collections.Generic;
using VL.Business.Entities;

namespace VL.Business.Services.Interface
{
    public interface IBadgeService
    {
        #region Badge
        BadgeDTO GetBadgeByID(int badgeID);
        IEnumerable<BadgeDTO> GetAllBadges();
        int CreateBadge(BadgeDTO badgeDTO);
        bool UpdateBadge(int badgeID, BadgeDTO badgeDTO);
        bool DeleteBadge(int badgeID);
        #endregion

        #region BadgeHistory
        IEnumerable<BadgeHistoryDTO> GetBadgeHistoryByBadgeID(int badgeID);
        #endregion

        #region BadgeType
        BadgeTypeDTO GetBadgeTypeByID(int badgeTypeID);
        IEnumerable<BadgeTypeDTO> GetAllBadgeTypes();
        int CreateBadgeType(BadgeTypeDTO badgeTypeDTO);
        bool UpdateBadgeType(int badgeTypeID, BadgeTypeDTO badgeTypeDTO);
        bool DeleteBadgeType(int bageTypeID);


        #endregion

        #region BadgeTypeHistory
        IEnumerable<BadgeTypeHistoryDTO> GetBadgeTypeHistoryByBadgeTypeID(int badgeID);
        #endregion
    }
}
