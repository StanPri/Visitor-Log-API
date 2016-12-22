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
    /// Implements a fake object wrapping <see cref="GenericRepository<Station>"/> to re-use in tests
    /// </summary>
    public class StationRepositoryFake : IGenericRepository<Station>
    {
        private List<Station> _allStations;

        #region Constructor
        public StationRepositoryFake(VisitorLogContext context)
        {
            _allStations = DataInitializer.GetAllStations();
        }
        #endregion

        #region IGenericRepository<Station> Implementation
        public IEnumerable<Station> GetAll()
        {
            return _allStations;
        }

        public Station GetByID(object id)
        {
            return _allStations.Find(s => s.ID.Equals(id));
        }

        public void Insert(Station entity)
        {
            var maxStationID = _allStations.Last().ID;
            var nextStationID = maxStationID + 1;
            entity.ID = nextStationID;
            _allStations.Add(entity);
        }
        public void Update(Station entityToUpdate)
        {
            var oldStation = _allStations.Find(a => a.ID.Equals(entityToUpdate.ID));
            if (oldStation != null)
            {
                _allStations.Remove(oldStation);
                _allStations.Add(entityToUpdate);
            }
        }
        public void Delete(Station entityToDelete)
        {
            var stationToRemove = _allStations.Find(a => a.ID.Equals(entityToDelete.ID));
            if (stationToRemove != null)
            {
                _allStations.Remove(stationToRemove);
            }
        }
        public void Delete(object id)
        {
            var stationToRemove = _allStations.Find(a => a.ID.Equals(id));
            if (stationToRemove != null)
                _allStations.Remove(stationToRemove);
        }

        #endregion

        #region Not Implemented
        //Note: The below methods are not implemented because we aren't using them in any test yet. 
        //  Once one needs to be used, implement it
        public void Delete(Func<Station, bool> where)
        {
            throw new NotImplementedException();
        }

        public bool Exists(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Station> Get()
        {
            throw new NotImplementedException();
        }

        public Station Get(Func<Station, bool> where)
        {
            throw new NotImplementedException();
        }


        public Station GetFirst(Func<Station, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Station> GetMany(Func<Station, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Station> GetManyQueryable(Func<Station, bool> where)
        {
            throw new NotImplementedException();
        }

        public Station GetSingle(Func<Station, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Station> GetWithInclude(Expression<Func<Station, bool>> predicate, params string[] include)
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
