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
    /// Implements a fake object wrapping <see cref="GenericRepository<Visitor>"/> to re-use in tests
    /// </summary>
    public class VisitorRepositoryFake : IGenericRepository<Visitor>
    {
        private List<Visitor> _allVisitors;

        #region Constructor
        public VisitorRepositoryFake(VisitorLogContext context)
        {
            _allVisitors = DataInitializer.GetAllVisitors();
        }
        #endregion

        #region IGenericRepository<Visitor> Implementation
        public IEnumerable<Visitor> GetAll()
        {
            return _allVisitors;
        }
        public Visitor GetByID(object id)
        {
            return _allVisitors.Find(v => v.ID.Equals(id));
        }
        public void Insert(Visitor entity)
        {
            var maxVisitorID = _allVisitors.Last().ID;
            var nextVisitorID = maxVisitorID + 1;
            entity.ID = nextVisitorID;
            _allVisitors.Add(entity);
        }
        public void Update(Visitor entityToUpdate)
        {
            var oldVisitor = _allVisitors.Find(a => a.ID.Equals(entityToUpdate.ID));
            if (oldVisitor != null)
            {
                _allVisitors.Remove(oldVisitor);
                _allVisitors.Add(entityToUpdate);
            }
        }
        public void Delete(Visitor entityToDelete)
        {
            var visitorToRemove = _allVisitors.Find(a => a.ID.Equals(entityToDelete.ID));
            if (visitorToRemove != null)
            {
                _allVisitors.Remove(visitorToRemove);
            }
        }

        #endregion

        #region Not Implemented
        //Note: The below methods are not implemented because we aren't using them in any test yet. 
        //  Once one needs to be used, implement it
        public void Delete(Func<Visitor, bool> where)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public bool Exists(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Visitor> Get()
        {
            throw new NotImplementedException();
        }

        public Visitor Get(Func<Visitor, bool> where)
        {
            throw new NotImplementedException();
        }

        public Visitor GetFirst(Func<Visitor, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Visitor> GetMany(Func<Visitor, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Visitor> GetManyQueryable(Func<Visitor, bool> where)
        {
            throw new NotImplementedException();
        }

        public Visitor GetSingle(Func<Visitor, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Visitor> GetWithInclude(Expression<Func<Visitor, bool>> predicate, params string[] include)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
