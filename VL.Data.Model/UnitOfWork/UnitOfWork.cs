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
        private GenericRepository<Asset> _assetRepository;
        private GenericRepository<AssetHistory> _assetHistoryRepository;
        private GenericRepository<AssetType> _assetTypeRepository;
        private GenericRepository<AssetTypeHistory> _assetTypeHistoryRepository;
        private GenericRepository<Badge> _badgeRepository;
        private GenericRepository<BadgeHistory> _badgeHistoryRepository;
        private GenericRepository<BadgeType> _badgeTypeRepository;
        private GenericRepository<BadgeTypeHistory> _badgeTypeHistoryRepository;
        private GenericRepository<Campus> _campusRepository;
        private GenericRepository<CampusHistory> _campusHistoryRepository;
        private GenericRepository<Company> _companyRepository;
        private GenericRepository<CompanyHistory> _companyHistoryRepository;
        private GenericRepository<Location> _locationRepository;
        private GenericRepository<LocationHistory> _locationHistoryRepository;
        private GenericRepository<Log> _logRepository;
        private GenericRepository<Station> _stationRepository;
        private GenericRepository<StationHistory> _stationHistoryRepository;
        private GenericRepository<Visit> _visitRepository;
        private GenericRepository<Visitor> _visitorRepository;

        #endregion

        #region Public Repository Creation properties...


        public GenericRepository<Asset> AssetRepository
        {
            get
            {
                if (this._assetRepository == null)
                    this._assetRepository = new GenericRepository<Asset>(_context);
                return _assetRepository;
            }
        }
        public GenericRepository<AssetHistory> AssetHistoryRepository
        {
            get
            {
                if (this._assetHistoryRepository == null)
                    this._assetHistoryRepository = new GenericRepository<AssetHistory>(_context);
                return _assetHistoryRepository;
            }
        }
        public GenericRepository<AssetType> AssetTypeRepository
        {
            get
            {
                if (this._assetTypeRepository == null)
                    this._assetTypeRepository = new GenericRepository<AssetType>(_context);
                return _assetTypeRepository;
            }
        }
        public GenericRepository<AssetTypeHistory> AssetTypeHistoryRepository
        {
            get
            {
                if (this._assetTypeHistoryRepository == null)
                    this._assetTypeHistoryRepository = new GenericRepository<AssetTypeHistory>(_context);
                return _assetTypeHistoryRepository;
            }
        }
        public GenericRepository<Badge> BadgeRepository
        {
            get
            {
                if (this._badgeRepository == null)
                    this._badgeRepository = new GenericRepository<Badge>(_context);
                return _badgeRepository;
            }
        }
        public GenericRepository<BadgeHistory> BadgeHistoryRepository
        {
            get
            {
                if (this._badgeHistoryRepository == null)
                    this._badgeHistoryRepository = new GenericRepository<BadgeHistory>(_context);
                return _badgeHistoryRepository;
            }
        }
        public GenericRepository<BadgeType> BadgeTypeRepository
        {
            get
            {
                if (this._badgeTypeRepository == null)
                    this._badgeTypeRepository = new GenericRepository<BadgeType>(_context);
                return _badgeTypeRepository;
            }
        }
        public GenericRepository<BadgeTypeHistory> BadgeTypeHistoryRepository
        {
            get
            {
                if (this._badgeTypeHistoryRepository == null)
                    this._badgeTypeHistoryRepository = new GenericRepository<BadgeTypeHistory>(_context);
                return _badgeTypeHistoryRepository;
            }
        }
        public GenericRepository<Campus> CampusRepository
        {
            get
            {
                if (this._campusRepository == null)
                    this._campusRepository = new GenericRepository<Campus>(_context);
                return _campusRepository;
            }
        }
        public GenericRepository<CampusHistory> CampusHistoryRepository
        {
            get
            {
                if (this._campusHistoryRepository == null)
                    this._campusHistoryRepository = new GenericRepository<CampusHistory>(_context);
                return _campusHistoryRepository;
            }
        }
        public GenericRepository<Company> CompanyRepository
        {
            get
            {
                if (this._companyRepository == null)
                    this._companyRepository = new GenericRepository<Company>(_context);
                return _companyRepository;
            }
        }
        public GenericRepository<CompanyHistory> CompanyHistoryRepository
        {
            get
            {
                if (this._companyHistoryRepository == null)
                    this._companyHistoryRepository = new GenericRepository<CompanyHistory>(_context);
                return _companyHistoryRepository;
            }
        }
        public GenericRepository<Location> LocationRepository
        {
            get
            {
                if (this._locationRepository == null)
                    this._locationRepository = new GenericRepository<Location>(_context);
                return _locationRepository;
            }
        }
        public GenericRepository<LocationHistory> LocationHistoryRepository
        {
            get
            {
                if (this._locationHistoryRepository == null)
                    this._locationHistoryRepository = new GenericRepository<LocationHistory>(_context);
                return _locationHistoryRepository;
            }
        }
        public GenericRepository<Log> LogRepository
        {
            get
            {
                if (this._logRepository == null)
                    this._logRepository = new GenericRepository<Log>(_context);
                return _logRepository;
            }
        }
        public GenericRepository<Station> StationRepository
        {
            get
            {
                if (this._stationRepository == null)
                    this._stationRepository = new GenericRepository<Station>(_context);
                return _stationRepository;
            }
        }
        public GenericRepository<StationHistory> StationHistoryRepository
        {
            get
            {
                if (this._stationHistoryRepository == null)
                    this._stationHistoryRepository = new GenericRepository<StationHistory>(_context);
                return _stationHistoryRepository;
            }
        }
        public GenericRepository<Visit> VisitRepository
        {
            get
            {
                if (this._visitRepository == null)
                    this._visitRepository = new GenericRepository<Visit>(_context);
                return _visitRepository;
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
