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
        private IGenericRepository<Asset> _assetRepository;
        private IGenericRepository<AssetHistory> _assetHistoryRepository;
        private IGenericRepository<AssetType> _assetTypeRepository;
        private IGenericRepository<AssetTypeHistory> _assetTypeHistoryRepository;
        private IGenericRepository<Badge> _badgeRepository;
        private IGenericRepository<BadgeHistory> _badgeHistoryRepository;
        private IGenericRepository<BadgeType> _badgeTypeRepository;
        private IGenericRepository<BadgeTypeHistory> _badgeTypeHistoryRepository;
        private IGenericRepository<Campus> _campusRepository;
        private IGenericRepository<CampusHistory> _campusHistoryRepository;
        private IGenericRepository<Company> _companyRepository;
        private IGenericRepository<CompanyHistory> _companyHistoryRepository;
        private IGenericRepository<Contact> _contactRepository;
        private IGenericRepository<Location> _locationRepository;
        private IGenericRepository<LocationHistory> _locationHistoryRepository;
        private IGenericRepository<Log> _logRepository;
        private IGenericRepository<Station> _stationRepository;
        private IGenericRepository<StationHistory> _stationHistoryRepository;
        private IGenericRepository<Visit> _visitRepository;
        private IGenericRepository<Visitor> _visitorRepository;
        #endregion

        #region Public Repository Creation properties...
        public IGenericRepository<Asset> AssetRepository
        {
            get
            {
                if (this._assetRepository == null)
                    this._assetRepository = new GenericRepository<Asset>(_context);
                return _assetRepository;
            }
        }
        public IGenericRepository<AssetHistory> AssetHistoryRepository
        {
            get
            {
                if (this._assetHistoryRepository == null)
                    this._assetHistoryRepository = new GenericRepository<AssetHistory>(_context);
                return _assetHistoryRepository;
            }
        }
        public IGenericRepository<AssetType> AssetTypeRepository
        {
            get
            {
                if (this._assetTypeRepository == null)
                    this._assetTypeRepository = new GenericRepository<AssetType>(_context);
                return _assetTypeRepository;
            }
        }
        public IGenericRepository<AssetTypeHistory> AssetTypeHistoryRepository
        {
            get
            {
                if (this._assetTypeHistoryRepository == null)
                    this._assetTypeHistoryRepository = new GenericRepository<AssetTypeHistory>(_context);
                return _assetTypeHistoryRepository;
            }
        }
        public IGenericRepository<Badge> BadgeRepository
        {
            get
            {
                if (this._badgeRepository == null)
                    this._badgeRepository = new GenericRepository<Badge>(_context);
                return _badgeRepository;
            }
        }
        public IGenericRepository<BadgeHistory> BadgeHistoryRepository
        {
            get
            {
                if (this._badgeHistoryRepository == null)
                    this._badgeHistoryRepository = new GenericRepository<BadgeHistory>(_context);
                return _badgeHistoryRepository;
            }
        }
        public IGenericRepository<BadgeType> BadgeTypeRepository
        {
            get
            {
                if (this._badgeTypeRepository == null)
                    this._badgeTypeRepository = new GenericRepository<BadgeType>(_context);
                return _badgeTypeRepository;
            }
        }
        public IGenericRepository<BadgeTypeHistory> BadgeTypeHistoryRepository
        {
            get
            {
                if (this._badgeTypeHistoryRepository == null)
                    this._badgeTypeHistoryRepository = new GenericRepository<BadgeTypeHistory>(_context);
                return _badgeTypeHistoryRepository;
            }
        }
        public IGenericRepository<Campus> CampusRepository
        {
            get
            {
                if (this._campusRepository == null)
                    this._campusRepository = new GenericRepository<Campus>(_context);
                return _campusRepository;
            }
        }
        public IGenericRepository<CampusHistory> CampusHistoryRepository
        {
            get
            {
                if (this._campusHistoryRepository == null)
                    this._campusHistoryRepository = new GenericRepository<CampusHistory>(_context);
                return _campusHistoryRepository;
            }
        }
        public IGenericRepository<Company> CompanyRepository
        {
            get
            {
                if (this._companyRepository == null)
                    this._companyRepository = new GenericRepository<Company>(_context);
                return _companyRepository;
            }
        }
        public IGenericRepository<CompanyHistory> CompanyHistoryRepository
        {
            get
            {
                if (this._companyHistoryRepository == null)
                    this._companyHistoryRepository = new GenericRepository<CompanyHistory>(_context);
                return _companyHistoryRepository;
            }
        }
        public IGenericRepository<Contact> ContactRepository
        {
            get
            {
                if (this._contactRepository == null)
                    this._contactRepository = new GenericRepository<Contact>(_context);
                return _contactRepository;
            }
        }
        public IGenericRepository<Location> LocationRepository
        {
            get
            {
                if (this._locationRepository == null)
                    this._locationRepository = new GenericRepository<Location>(_context);
                return _locationRepository;
            }
        }
        public IGenericRepository<LocationHistory> LocationHistoryRepository
        {
            get
            {
                if (this._locationHistoryRepository == null)
                    this._locationHistoryRepository = new GenericRepository<LocationHistory>(_context);
                return _locationHistoryRepository;
            }
        }
        public IGenericRepository<Log> LogRepository
        {
            get
            {
                if (this._logRepository == null)
                    this._logRepository = new GenericRepository<Log>(_context);
                return _logRepository;
            }
        }
        public IGenericRepository<Station> StationRepository
        {
            get
            {
                if (this._stationRepository == null)
                    this._stationRepository = new GenericRepository<Station>(_context);
                return _stationRepository;
            }
        }
        public IGenericRepository<StationHistory> StationHistoryRepository
        {
            get
            {
                if (this._stationHistoryRepository == null)
                    this._stationHistoryRepository = new GenericRepository<StationHistory>(_context);
                return _stationHistoryRepository;
            }
        }
        public IGenericRepository<Visit> VisitRepository
        {
            get
            {
                if (this._visitRepository == null)
                    this._visitRepository = new GenericRepository<Visit>(_context);
                return _visitRepository;
            }
        }
        public IGenericRepository<Visitor> VisitorRepository
        {
            get
            {
                if (this._visitorRepository == null)
                    this._visitorRepository = new GenericRepository<Visitor>(_context);
                return _visitorRepository;
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
                //System.IO.File.AppendAllLines(@"C:\errors.txt", outputLines);

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
