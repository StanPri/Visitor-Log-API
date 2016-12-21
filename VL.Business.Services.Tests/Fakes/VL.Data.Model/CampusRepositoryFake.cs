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
    /// Implements a fake object wrapping <see cref="GenericRepository<Campus>"/> to re-use in tests
    /// </summary>
    public class CampusRepositoryFake : IGenericRepository<Campus>
    {
        private List<Campus> _allCampuses;

        public CampusRepositoryFake(VisitorLogContext context)
        {
            _allCampuses = DataInitializer.GetAllCampuses();
        }

        public IEnumerable<Campus> GetAll()
        {
            return _allCampuses;
        }

        public Campus GetByID(object id)
        {
            return _allCampuses.Find(p => p.ID.Equals(id));
        }

        public void Insert(Campus entity)
        {
            var maxCampusID = _allCampuses.Last().ID;
            var nextCampusID = maxCampusID + 1;
            entity.ID = nextCampusID;
            _allCampuses.Add(entity);
        }

        public void Update(Campus entityToUpdate)
        {
            var oldCampus = _allCampuses.Find(a => a.ID == entityToUpdate.ID);
            if (oldCampus != null)
            {
                _allCampuses.Remove(oldCampus);
                _allCampuses.Add(entityToUpdate);
            }
        }

        public void Delete(Campus entityToDelete)
        {
            var campToRemove = _allCampuses.Find(a => a.ID == entityToDelete.ID);
            if (campToRemove != null)
            {
                _allCampuses.Remove(campToRemove);
            }
        }

        #region Not Implemented
        //Note: The below methods are not implemented because we aren't using them in any test yet. 
        //  Once one needs to be used, implement it

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Campus> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Campus> GetMany(Func<Campus, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Campus> GetManyQueryable(Func<Campus, bool> where)
        {
            throw new NotImplementedException();
        }

        public Campus Get(Func<Campus, bool> where)
        {
            throw new NotImplementedException();
        }

        public void Delete(Func<Campus, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Campus> GetWithInclude(Expression<Func<Campus, bool>> predicate, params string[] include)
        {
            throw new NotImplementedException();
        }

        public bool Exists(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public Campus GetSingle(Func<Campus, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Campus GetFirst(Func<Campus, bool> predicate)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
