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
    /// Implements a fake object wrapping <see cref="GenericRepository<Company>"/> to re-use in tests
    /// </summary>
    public class CompanyRepositoryFake : IGenericRepository<Company>
    {
        private List<Company> _allCompanies;

        #region Constructor
        public CompanyRepositoryFake(VisitorLogContext context)
        {
            _allCompanies = DataInitializer.GetAllCompanies();
        }
        #endregion

        #region IGenericRepository<Company> Implementation
        public IEnumerable<Company> GetAll()
        {
            return _allCompanies;
        }

        public Company GetByID(object id)
        {
            return _allCompanies.Find(c => c.ID.Equals(id));
        }

        public void Insert(Company entity)
        {
            var maxCompanyID = _allCompanies.Last().ID;
            var nextCompanyID = maxCompanyID + 1;
            entity.ID = nextCompanyID;
            _allCompanies.Add(entity);
        }

        public void Update(Company entityToUpdate)
        {
            var oldCompany = _allCompanies.Find(a => a.ID == entityToUpdate.ID);
            if (oldCompany != null)
            {
                _allCompanies.Remove(oldCompany);
                _allCompanies.Add(entityToUpdate);
            }
        }
        public void Delete(Company entityToDelete)
        {
            var companyToRemove = _allCompanies.Find(a => a.ID == entityToDelete.ID);
            if (companyToRemove != null)
            {
                _allCompanies.Remove(companyToRemove);
            }
        }

        #endregion

        #region Not Implemented
        //Note: The below methods are not implemented because we aren't using them in any test yet. 
        //  Once one needs to be used, implement it

        public void Delete(Func<Company, bool> where)
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

        public IEnumerable<Company> Get()
        {
            throw new NotImplementedException();
        }

        public Company Get(Func<Company, bool> where)
        {
            throw new NotImplementedException();
        }

        public Company GetFirst(Func<Company, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetMany(Func<Company, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Company> GetManyQueryable(Func<Company, bool> where)
        {
            throw new NotImplementedException();
        }

        public Company GetSingle(Func<Company, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Company> GetWithInclude(Expression<Func<Company, bool>> predicate, params string[] include)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
