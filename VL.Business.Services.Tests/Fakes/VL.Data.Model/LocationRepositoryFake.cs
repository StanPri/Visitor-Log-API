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
    public class LocationRepositoryFake : IGenericRepository<Location>
    {
        private List<Location> _allLocations;

        #region Constructor
        public LocationRepositoryFake(VisitorLogContext context)
        {
            _allLocations = DataInitializer.GetAllLocations();
        }
        #endregion

        #region IGenericRepository<Location> Implementation
        public IEnumerable<Location> GetAll()
        {
            return _allLocations;
        }
        public Location GetByID(object id)
        {
            return _allLocations.Find(l => l.ID.Equals(id));
        }
        public void Insert(Location entity)
        {
            var maxLocID = _allLocations.Last().ID;
            var nextLocID = maxLocID + 1;
            entity.ID = nextLocID;
            _allLocations.Add(entity);
        }
        public void Update(Location entityToUpdate)
        {
            var oldLocation = _allLocations.Find(a => a.ID.Equals(entityToUpdate.ID));
            if (oldLocation != null)
            {
                _allLocations.Remove(oldLocation);
                _allLocations.Add(entityToUpdate);
            }
        }
        public void Delete(Location entityToDelete)
        {
            var locToRemove = _allLocations.Find(a => a.ID.Equals(entityToDelete.ID));
            if (locToRemove != null)
            {
                _allLocations.Remove(locToRemove);
            }
        }
        public void Delete(object id)
        {
            var locationToRemove = _allLocations.Find(a => a.ID.Equals(id));
            if (locationToRemove != null)
                _allLocations.Remove(locationToRemove);
        }
        #endregion

        #region Not Implemented
        //Note: The below methods are not implemented because we aren't using them in any test yet. 
        //  Once one needs to be used, implement it
        public void Delete(Func<Location, bool> where)
        {
            throw new NotImplementedException();
        }

        public bool Exists(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Location> Get()
        {
            throw new NotImplementedException();
        }

        public Location Get(Func<Location, bool> where)
        {
            throw new NotImplementedException();
        }

        public Location GetFirst(Func<Location, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Location> GetMany(Func<Location, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Location> GetManyQueryable(Func<Location, bool> where)
        {
            throw new NotImplementedException();
        }

        public Location GetSingle(Func<Location, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Location> GetWithInclude(Expression<Func<Location, bool>> predicate, params string[] include)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
