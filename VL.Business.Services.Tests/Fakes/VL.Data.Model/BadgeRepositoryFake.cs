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
    /// Implements a fake object wrapping <see cref="GenericRepository<Badge>"/> to re-use in tests
    /// </summary>
    public class BadgeRepositoryFake : IGenericRepository<Badge>
    {
        private List<Badge> _allBadges;

        #region Constructor
        public BadgeRepositoryFake(VisitorLogContext context)
        {
            _allBadges = DataInitializer.GetAllBadges();
        }
        #endregion

        #region IGenericRepository<Badge> Implementation
        public IEnumerable<Badge> GetAll()
        {
            return _allBadges;
        }
        public Badge GetByID(object id)
        {
            return _allBadges.Find(b => b.ID.Equals(id));
        }
        public void Insert(Badge entity)
        {
            var maxBadgeID = _allBadges.Last().ID;
            var nextBadgeID = maxBadgeID + 1;
            entity.ID = nextBadgeID;
            _allBadges.Add(entity);
        }
        public void Update(Badge entityToUpdate)
        {
            var oldBadge = _allBadges.Find(a => a.ID.Equals(entityToUpdate.ID));
            if (oldBadge != null)
            {
                _allBadges.Remove(oldBadge);
                _allBadges.Add(entityToUpdate);
            }
        }
        public void Delete(Badge entityToDelete)
        {
            var badToRemove = _allBadges.Find(a => a.ID.Equals(entityToDelete.ID));
            if (badToRemove != null)
            {
                _allBadges.Remove(badToRemove);
            }
        }
        public void Delete(object id)
        {
            var badgeToRemove = _allBadges.Find(a => a.ID.Equals(id));
            if (badgeToRemove != null)
                _allBadges.Remove(badgeToRemove);
        }
        #endregion

        #region Not Implemented
        //Note: The below methods are not implemented because we aren't using them in any test yet. 
        //  Once one needs to be used, implement it

        public void Delete(Func<Badge, bool> where)
        {
            throw new NotImplementedException();
        }

        public bool Exists(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Badge> Get()
        {
            throw new NotImplementedException();
        }

        public Badge Get(Func<Badge, bool> where)
        {
            throw new NotImplementedException();
        }

        public Badge GetFirst(Func<Badge, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Badge> GetMany(Func<Badge, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Badge> GetManyQueryable(Func<Badge, bool> where)
        {
            throw new NotImplementedException();
        }

        public Badge GetSingle(Func<Badge, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Badge> GetWithInclude(Expression<Func<Badge, bool>> predicate, params string[] include)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
