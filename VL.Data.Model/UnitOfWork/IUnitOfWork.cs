
using VL.Data.Model.GenericRepository;
namespace VL.Data.Model
{
    public interface IUnitOfWork
    {

        #region Properties

        IGenericRepository<Asset> AssetRepository { get; }
        IGenericRepository<AssetHistory> AssetHistoryRepository { get; }
        IGenericRepository<AssetType> AssetTypeRepository { get; }
        IGenericRepository<AssetTypeHistory> AssetTypeHistoryRepository { get; }
        IGenericRepository<Badge> BadgeRepository { get; }
        IGenericRepository<BadgeHistory> BadgeHistoryRepository { get; }
        IGenericRepository<BadgeType> BadgeTypeRepository { get; }
        IGenericRepository<BadgeTypeHistory> BadgeTypeHistoryRepository { get; }
        IGenericRepository<Campus> CampusRepository { get; }
        IGenericRepository<CampusHistory> CampusHistoryRepository { get; }
        IGenericRepository<Company> CompanyRepository { get; }
        IGenericRepository<Contact> ContactRepository { get; }
        IGenericRepository<CompanyHistory> CompanyHistoryRepository { get; }
        IGenericRepository<Location> LocationRepository { get; }
        IGenericRepository<LocationHistory> LocationHistoryRepository { get; }
        IGenericRepository<Log> LogRepository { get; }
        IGenericRepository<Station> StationRepository { get; }
        IGenericRepository<StationHistory> StationHistoryRepository { get; }
        IGenericRepository<Visit> VisitRepository { get; }
        IGenericRepository<Visitor> VisitorRepository { get; }
        #endregion

        /// <summary>
        /// Save method.
        /// </summary>
        void Save();
    }
}
