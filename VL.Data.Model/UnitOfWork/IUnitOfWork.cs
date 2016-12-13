
using VL.Data.Model.GenericRepository;
namespace VL.Data.Model
{
    public interface IUnitOfWork
    {

        #region Properties

        GenericRepository<Asset> AssetRepository { get; }
        GenericRepository<AssetHistory> AssetHistoryRepository { get; }
        GenericRepository<AssetType> AssetTypeRepository { get; }
        GenericRepository<AssetTypeHistory> AssetTypeHistoryRepository { get; }
        GenericRepository<Badge> BadgeRepository { get; }
        GenericRepository<BadgeHistory> BadgeHistoryRepository { get; }
        GenericRepository<BadgeType> BadgeTypeRepository { get; }
        GenericRepository<BadgeTypeHistory> BadgeTypeHistoryRepository { get; }
        GenericRepository<Campus> CampusRepository { get; }
        GenericRepository<CampusHistory> CampusHistoryRepository { get; }
        GenericRepository<Company> CompanyRepository { get; }
        GenericRepository<CompanyHistory> CompanyHistoryRepository { get; }
        GenericRepository<Location> LocationRepository { get; }
        GenericRepository<LocationHistory> LocationHistoryRepository { get; }
        GenericRepository<Log> LogRepository { get; }
        GenericRepository<Station> StationRepository { get; }
        GenericRepository<StationHistory> StationHistoryRepository { get; }
        GenericRepository<Visit> VisitRepository { get; }
        GenericRepository<Visitor> VisitorRepository { get; }
        #endregion

        /// <summary>
        /// Save method.
        /// </summary>
        void Save();
    }
}
