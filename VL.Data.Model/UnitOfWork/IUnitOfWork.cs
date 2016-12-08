
using VL.Data.Model.GenericRepository;
namespace VL.Data.Model
{
    public interface IUnitOfWork
    {
        #region Properties
        GenericRepository<AccessArea> AccessAreaRepository { get; }
        GenericRepository<EmployeeRole> EmployeeRoleRepository { get; }
        GenericRepository<EmpRef> EmpRefRepository { get; }
        GenericRepository<LogCounter> LogCounterRepository { get; }
        GenericRepository<Role> RoleRepository { get; }
        GenericRepository<Room> RoomRepository { get; }
        GenericRepository<SecuredArea> SecuredAreaRepository { get; }
        GenericRepository<TenantDepartment> TenantDepartmentRepository { get; }
        GenericRepository<BadgeType> BadgeTypeRepository { get; }
        GenericRepository<Visitor> VisitorRepository { get; }
        GenericRepository<VisitorCheckInOut> VisitorCheckInOutRepository { get; }
        GenericRepository<VisitorDetail> VisitorDetailRepository { get; }
        GenericRepository<VisitorFile> VisitorFileRepository { get; }
        GenericRepository<VisitorLog> VisitorLogRepository { get; }
        GenericRepository<VisitorLogAccessID> VisitorLogAccessIDRepository { get; }
        GenericRepository<VisitorLogRoomID> VisitorLogRoomIDRepository  { get; }
        #endregion

        /// <summary>
        /// Save method.
        /// </summary>
        void Save();
    }
}
