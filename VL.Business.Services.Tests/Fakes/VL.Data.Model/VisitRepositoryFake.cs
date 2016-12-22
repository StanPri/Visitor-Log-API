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
    /// Implements a fake object wrapping <see cref="GenericRepository<Visit>"/> to re-use in tests
    /// </summary>
    public class VisitRepositoryFake : IGenericRepository<Visit>
    {
        private List<Visit> _allVisits;

        #region Constructor
        public VisitRepositoryFake(VisitorLogContext context)
        {
            _allVisits = DataInitializer.GetAllVisits();
        }
        #endregion

        #region IGenericRepository<Visit> Implementation
        public IEnumerable<Visit> GetAll()
        {
            return _allVisits;
        }
        public Visit GetByID(object id)
        {
            return _allVisits.Find(v => v.ID.Equals(id));
        }
        public void Insert(Visit entity)
        {
            var maxVisitID = _allVisits.Last().ID;
            var nextVisitID = maxVisitID + 1;
            entity.ID = nextVisitID;
            _allVisits.Add(entity);
        }
        public void Update(Visit entityToUpdate)
        {
            var oldVisit = _allVisits.Find(a => a.ID.Equals(entityToUpdate.ID));
            if (oldVisit != null)
            {
                _allVisits.Remove(oldVisit);
                _allVisits.Add(entityToUpdate);
            }
        }
        public void Delete(Visit entityToDelete)
        {
            var visitToRemove = _allVisits.Find(a => a.ID.Equals(entityToDelete.ID));
            if (visitToRemove != null)
            {
                _allVisits.Remove(visitToRemove);
            }
        }
        public void Delete(object id)
        {
            var visitToRemove = _allVisits.Find(a => a.ID.Equals(id));
            if (visitToRemove != null)
                _allVisits.Remove(visitToRemove);
        }

        #endregion

        #region Not Implemented
        //Note: The below methods are not implemented because we aren't using them in any test yet. 
        //  Once one needs to be used, implement it
        public void Delete(Func<Visit, bool> where)
        {
            throw new NotImplementedException();
        }

        public bool Exists(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Visit> Get()
        {
            throw new NotImplementedException();
        }

        public Visit Get(Func<Visit, bool> where)
        {
            throw new NotImplementedException();
        }

        public Visit GetFirst(Func<Visit, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Visit> GetMany(Func<Visit, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Visit> GetManyQueryable(Func<Visit, bool> where)
        {
            throw new NotImplementedException();
        }

        public Visit GetSingle(Func<Visit, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Visit> GetWithInclude(Expression<Func<Visit, bool>> predicate, params string[] include)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
