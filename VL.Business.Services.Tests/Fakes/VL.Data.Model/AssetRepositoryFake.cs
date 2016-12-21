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
    /// Implements a fake object wrapping <see cref="GenericRepository<Asset>"/> to re-use in tests
    /// </summary>
    public class AssetRepositoryFake : IGenericRepository<Asset>
    {
        private List<Asset> _allAssets;

        #region Constructor
        public AssetRepositoryFake(VisitorLogContext context)
        {
            _allAssets = DataInitializer.GetAllAssets();
        }
        #endregion

        #region IGenericRepository<Asset> Implementation
        public IEnumerable<Asset> GetAll()
        {
            return _allAssets;
        }

        public Asset GetByID(object id)
        {
            return _allAssets.Find(p => p.ID.Equals(id));
        }

        public void Insert(Asset entity)
        {
            var maxAssetID = _allAssets.Last().ID;
            var nextAssetID = maxAssetID + 1;
            entity.ID = nextAssetID;
            _allAssets.Add(entity);
        }

        public void Update(Asset entityToUpdate)
        {
            var oldAsset = _allAssets.Find(a => a.ID == entityToUpdate.ID);
            if (oldAsset != null)
            {
                _allAssets.Remove(oldAsset);
                _allAssets.Add(entityToUpdate);
            }
        }

        public void Delete(Asset entityToDelete)
        {
            var assToRemove = _allAssets.Find(a => a.ID == entityToDelete.ID);
            if (assToRemove != null)
            {
                _allAssets.Remove(assToRemove);
            }
        }
        #endregion

        #region Not Implemented
        //Note: The below methods are not implemented because we aren't using them in any test yet. 
        //  Once one needs to be used, implement it
        public void Delete(Func<Asset, bool> where)
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

        public IEnumerable<Asset> Get()
        {
            throw new NotImplementedException();
        }

        public Asset Get(Func<Asset, bool> where)
        {
            throw new NotImplementedException();
        }

        public Asset GetFirst(Func<Asset, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Asset> GetMany(Func<Asset, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Asset> GetManyQueryable(Func<Asset, bool> where)
        {
            throw new NotImplementedException();
        }

        public Asset GetSingle(Func<Asset, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Asset> GetWithInclude(Expression<Func<Asset, bool>> predicate, params string[] include)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
