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
    /// Implements a fake object wrapping <see cref="GenericRepository<AssetType>"/> to re-use in tests
    /// </summary>
    public class AssetTypeRepositoryFake : IGenericRepository<AssetType>
    {
        private List<AssetType> _allAssetTypes;

        #region Constructor
        public AssetTypeRepositoryFake(VisitorLogContext context)
        {
            _allAssetTypes = DataInitializer.GetAllAssetTypes();
        }
        #endregion

        #region IGenericRepository<AssetType> Implementation
        public IEnumerable<AssetType> GetAll()
        {
            return _allAssetTypes;
        }

        public AssetType GetByID(object id)
        {
            return _allAssetTypes.Find(a => a.ID.Equals(id));
        }

        public void Insert(AssetType entity)
        {
            var maxAssetTypeID = _allAssetTypes.Last().ID;
            var nextAssetTypeID = maxAssetTypeID + 1;
            entity.ID = nextAssetTypeID;
            _allAssetTypes.Add(entity);
        }

        public void Update(AssetType entityToUpdate)
        {
            var oldAssetType = _allAssetTypes.Find(a => a.ID.Equals(entityToUpdate.ID));
            if (oldAssetType != null)
            {
                _allAssetTypes.Remove(oldAssetType);
                _allAssetTypes.Add(entityToUpdate);
            }
        }

        public void Delete(AssetType entityToDelete)
        {
            var assetTypeToRemove = _allAssetTypes.Find(a => a.ID.Equals(entityToDelete.ID));
            if (assetTypeToRemove != null) _allAssetTypes.Remove(assetTypeToRemove);
        }

        public void Delete(object id)
        {
            var assetTypeToRemove = _allAssetTypes.Find(at => at.ID.Equals(id));
            if (assetTypeToRemove != null) _allAssetTypes.Remove(assetTypeToRemove);
        }

        #endregion

        #region Not Implemented
        //Note: The below methods are not implemented because we aren't using them in any test yet. 
        //  Once one needs to be used, implement it

        public void Delete(Func<AssetType, bool> where)
        {
            throw new NotImplementedException();
        }


        public bool Exists(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AssetType> Get()
        {
            throw new NotImplementedException();
        }

        public AssetType Get(Func<AssetType, bool> where)
        {
            throw new NotImplementedException();
        }


        public AssetType GetFirst(Func<AssetType, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AssetType> GetMany(Func<AssetType, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<AssetType> GetManyQueryable(Func<AssetType, bool> where)
        {
            throw new NotImplementedException();
        }

        public AssetType GetSingle(Func<AssetType, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<AssetType> GetWithInclude(Expression<Func<AssetType, bool>> predicate, params string[] include)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
