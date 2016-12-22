using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VL.Data.Model;
using VL.Data.Model.GenericRepository;
using VL.Tests.Helpers;

namespace VL.Business.Services.Tests.Fakes.VL.Data.Model
{
    /// <summary>
    /// Implements a fake object wrapping <see cref="GenericRepository<Log>"/> to re-use in tests
    /// </summary>
    public class LogRepositoryFake : IGenericRepository<Log>
    {
        private List<Log> _allLogs;

        #region Constructor
        public LogRepositoryFake(VisitorLogContext context)
        {
            _allLogs = DataInitializer.GetAllLogs();
        }
        #endregion

        #region IGenericRepository<Log> Implementation
        public IEnumerable<Log> GetAll()
        {
            return _allLogs;
        }
        public Log GetByID(object id)
        {
            return _allLogs.Find(l => l.ID.Equals(id));
        }
        public void Insert(Log entity)
        {
            var maxLogID = _allLogs.Last().ID;
            var nextLogID = maxLogID + 1;
            entity.ID = nextLogID;
            _allLogs.Add(entity);
        }
        public void Update(Log entityToUpdate)
        {
            var oldLog = _allLogs.Find(a => a.ID.Equals(entityToUpdate.ID));
            if (oldLog != null)
            {
                _allLogs.Remove(oldLog);
                _allLogs.Add(entityToUpdate);
            }
        }
        public void Delete(Log entityToDelete)
        {
            var logToRemove = _allLogs.Find(a => a.ID.Equals(entityToDelete.ID));
            if (logToRemove != null)
            {
                _allLogs.Remove(logToRemove);
            }
        }
        public void Delete(object id)
        {
            var logToRemove = _allLogs.Find(a => a.ID.Equals(id));
            if (logToRemove != null)
                _allLogs.Remove(logToRemove);
        }
        #endregion

        #region Not Implemented

        public void Delete(Func<Log, bool> where)
        {
            throw new NotImplementedException();
        }

        public bool Exists(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Log> Get()
        {
            throw new NotImplementedException();
        }

        public Log Get(Func<Log, bool> where)
        {
            throw new NotImplementedException();
        }

        public Log GetFirst(Func<Log, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Log> GetMany(Func<Log, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Log> GetManyQueryable(Func<Log, bool> where)
        {
            throw new NotImplementedException();
        }

        public Log GetSingle(Func<Log, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Log> GetWithInclude(Expression<Func<Log, bool>> predicate, params string[] include)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
