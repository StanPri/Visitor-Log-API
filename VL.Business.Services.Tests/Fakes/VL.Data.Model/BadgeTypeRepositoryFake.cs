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
    /// Implements a fake object wrapping <see cref="GenericRepository<BadgeType>"/> to re-use in tests
    /// </summary>
    public class BadgeTypeRepositoryFake : IGenericRepository<BadgeType>
    {

        private List<BadgeType> _allBadgeTypes;

        #region Constructor
        public BadgeTypeRepositoryFake(VisitorLogContext context)
        {
            _allBadgeTypes = DataInitializer.GetAllBadgeTypes();
        }
        #endregion

        #region IGenericRepository<BadgeType> Implementation
        public IEnumerable<BadgeType> GetAll()
        {
            return _allBadgeTypes;
        }

        public BadgeType GetByID(object id)
        {
            return _allBadgeTypes.Find(bt => bt.ID.Equals(id));
        }

        public void Insert(BadgeType entity)
        {
            var maxBadgeTypeID = _allBadgeTypes.Last().ID;
            var nextBadgeTypeID = maxBadgeTypeID + 1;
            entity.ID = nextBadgeTypeID;
            _allBadgeTypes.Add(entity);
        }
        public void Update(BadgeType entityToUpdate)
        {
            var oldBadgeType = _allBadgeTypes.Find(a => a.ID == entityToUpdate.ID);
            if (oldBadgeType != null)
            {
                _allBadgeTypes.Remove(oldBadgeType);
                _allBadgeTypes.Add(entityToUpdate);
            }
        }
        public void Delete(BadgeType entityToDelete)
        {
            var badgeTypeToRemove = _allBadgeTypes.Find(a => a.ID == entityToDelete.ID);
            if (badgeTypeToRemove != null)
            {
                _allBadgeTypes.Remove(badgeTypeToRemove);
            }
        }

        #endregion

        #region Not Implemented

        public void Delete(Func<BadgeType, bool> where)
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

        public IEnumerable<BadgeType> Get()
        {
            throw new NotImplementedException();
        }

        public BadgeType Get(Func<BadgeType, bool> where)
        {
            throw new NotImplementedException();
        }

        public BadgeType GetFirst(Func<BadgeType, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BadgeType> GetMany(Func<BadgeType, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<BadgeType> GetManyQueryable(Func<BadgeType, bool> where)
        {
            throw new NotImplementedException();
        }

        public BadgeType GetSingle(Func<BadgeType, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<BadgeType> GetWithInclude(Expression<Func<BadgeType, bool>> predicate, params string[] include)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
