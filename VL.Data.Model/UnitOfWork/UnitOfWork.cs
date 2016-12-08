using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using VL.Data.Model.GenericRepository;

namespace VL.Data.Model
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        #region Constructor
        public UnitOfWork()
        {
            _context = new VisitorLogContext();
        }
        #endregion

        #region Private member variables...

        private readonly VisitorLogContext _context = null;
        private GenericRepository<AccessArea> _accessAreaRepository;
        private GenericRepository<EmployeeRole> _employeeRoleRepository;
        private GenericRepository<EmpRef> _empRefRepository;
        private GenericRepository<LogCounter> _logCounterRepository;
        private GenericRepository<Role> _roleRepository;
        private GenericRepository<Room> _roomRepository;
        private GenericRepository<SecuredArea> _securedAreaRepository;
        private GenericRepository<TenantDepartment> _tenantDepartmentRepository;
        private GenericRepository<BadgeType> _typeRepository;
        private GenericRepository<Visitor> _visitorRepository;
        private GenericRepository<VisitorCheckInOut> _visitorCheckInOutRepository;
        private GenericRepository<VisitorDetail> _visitorDetailRepository;
        private GenericRepository<VisitorFile> _visitorFileRepository;
        private GenericRepository<VisitorLog> _visitorLogRepository;
        private GenericRepository<VisitorLogAccessID> _visitorLogAccessIDRepository;
        private GenericRepository<VisitorLogRoomID> _visitorLogRoomIDRepository;

        #endregion

        #region Public Repository Creation properties...
        public GenericRepository<AccessArea> AccessAreaRepository
        {
            get
            {
                if (this._accessAreaRepository == null)
                    this._accessAreaRepository = new GenericRepository<AccessArea>(_context);
                return _accessAreaRepository;
            }
        }
        public GenericRepository<EmployeeRole> EmployeeRoleRepository
        {
            get
            {
                if (this._employeeRoleRepository == null)
                    this._employeeRoleRepository = new GenericRepository<EmployeeRole>(_context);
                return _employeeRoleRepository;
            }
        }
        public GenericRepository<EmpRef> EmpRefRepository
        {
            get
            {
                if (this._empRefRepository == null)
                    this._empRefRepository = new GenericRepository<EmpRef>(_context);
                return _empRefRepository;
            }
        }
        public GenericRepository<LogCounter> LogCounterRepository
        {
            get
            {
                if (this._logCounterRepository == null)
                    this._logCounterRepository = new GenericRepository<LogCounter>(_context);
                return _logCounterRepository;
            }
        }
        public GenericRepository<Role> RoleRepository
        {
            get
            {
                if (this._roleRepository == null)
                    this._roleRepository = new GenericRepository<Role>(_context);
                return _roleRepository;
            }
        }
        public GenericRepository<Room> RoomRepository
        {
            get
            {
                if (this._roomRepository == null)
                    this._roomRepository = new GenericRepository<Room>(_context);
                return _roomRepository;
            }
        }
        public GenericRepository<SecuredArea> SecuredAreaRepository
        {
            get
            {
                if (this._securedAreaRepository == null)
                    this._securedAreaRepository = new GenericRepository<SecuredArea>(_context);
                return _securedAreaRepository;
            }
        }
        public GenericRepository<TenantDepartment> TenantDepartmentRepository
        {
            get
            {
                if (this._tenantDepartmentRepository == null)
                    this._tenantDepartmentRepository = new GenericRepository<TenantDepartment>(_context);
                return _tenantDepartmentRepository;
            }
        }
        public GenericRepository<BadgeType> BadgeTypeRepository
        {
            get
            {
                if (this._typeRepository == null)
                    this._typeRepository = new GenericRepository<BadgeType>(_context);
                return _typeRepository;
            }
        }
        public GenericRepository<Visitor> VisitorRepository
        {
            get
            {
                if (this._visitorRepository == null)
                    this._visitorRepository = new GenericRepository<Visitor>(_context);
                return _visitorRepository;
            }
        }
        public GenericRepository<VisitorCheckInOut> VisitorCheckInOutRepository
        {
            get
            {
                if (this._visitorCheckInOutRepository == null)
                    this._visitorCheckInOutRepository = new GenericRepository<VisitorCheckInOut>(_context);
                return _visitorCheckInOutRepository;
            }
        }
        public GenericRepository<VisitorDetail> VisitorDetailRepository
        {
            get
            {
                if (this._visitorDetailRepository == null)
                    this._visitorDetailRepository = new GenericRepository<VisitorDetail>(_context);
                return _visitorDetailRepository;
            }
        }
        public GenericRepository<VisitorFile> VisitorFileRepository
        {
            get
            {
                if (this._visitorFileRepository == null)
                    this._visitorFileRepository = new GenericRepository<VisitorFile>(_context);
                return _visitorFileRepository;
            }
        }
        public GenericRepository<VisitorLog> VisitorLogRepository
        {
            get
            {
                if (this._visitorLogRepository == null)
                    this._visitorLogRepository = new GenericRepository<VisitorLog>(_context);
                return _visitorLogRepository;
            }
        }
        public GenericRepository<VisitorLogAccessID> VisitorLogAccessIDRepository
        {
            get
            {
                if (this._visitorLogAccessIDRepository == null)
                    this._visitorLogAccessIDRepository = new GenericRepository<VisitorLogAccessID>(_context);
                return _visitorLogAccessIDRepository;
            }
        }
        public GenericRepository<VisitorLogRoomID> VisitorLogRoomIDRepository
        {
            get
            {
                if (this._visitorLogRoomIDRepository == null)
                    this._visitorLogRoomIDRepository = new GenericRepository<VisitorLogRoomID>(_context);
                return _visitorLogRoomIDRepository;
            }
        }
        #endregion

        #region Public member methods...
        /// <summary>
        /// Save method.
        /// </summary>
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                var outputLines = new List<string>();
                foreach (var eve in e.EntityValidationErrors)
                {
                    outputLines.Add(string.Format("{0}: Entity of type \"{1}\" in state \"{2}\" has the following validation errors:", DateTime.Now, eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        outputLines.Add(string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }
                System.IO.File.AppendAllLines(@"C:\errors.txt", outputLines);

                throw e;
            }
        }

        #endregion

        #region Implementing IDisposable

        #region private dispose variable declaration...
        private bool disposed = false;
        #endregion

        /// <summary>
        /// Protected Virtual Dispose method
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Debug.WriteLine("UnitOfWork is being disposed");
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
