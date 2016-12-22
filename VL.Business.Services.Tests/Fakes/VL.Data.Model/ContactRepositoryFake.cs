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
    /// Implements a fake object wrapping <see cref="GenericRepository<Contact>"/> to re-use in tests
    /// </summary>
    public class ContactRepositoryFake : IGenericRepository<Contact>
    {
        private List<Contact> _allContacts;

        #region Constructor
        public ContactRepositoryFake(VisitorLogContext context)
        {
            _allContacts = DataInitializer.GetAllContacts();
        }
        #endregion

        #region IGenericRepository<Contact> Implementation
        public IEnumerable<Contact> GetAll()
        {
            return _allContacts;
        }
        public Contact GetByID(object id)
        {
            return _allContacts.Find(c => c.ID.Equals(id));
        }
        public void Insert(Contact entity)
        {
            var maxContactID = _allContacts.Last().ID;
            var nextContactID = maxContactID + 1;
            entity.ID = nextContactID;
            _allContacts.Add(entity);
        }
        public void Update(Contact entityToUpdate)
        {
            var oldContact = _allContacts.Find(a => a.ID.Equals(entityToUpdate.ID));
            if (oldContact != null)
            {
                _allContacts.Remove(oldContact);
                _allContacts.Add(entityToUpdate);
            }
        }
        public void Delete(Contact entityToDelete)
        {
            var contactToRemove = _allContacts.Find(a => a.ID.Equals(entityToDelete.ID));
            if (contactToRemove != null)
            {
                _allContacts.Remove(contactToRemove);
            }
        }
        public void Delete(object id)
        {
            var contactToRemove = _allContacts.Find(a => a.ID.Equals(id));
            if (contactToRemove != null)
                _allContacts.Remove(contactToRemove);
        }
        #endregion

        #region Not Implemented

        public void Delete(Func<Contact, bool> where)
        {
            throw new NotImplementedException();
        }

        public bool Exists(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> Get()
        {
            throw new NotImplementedException();
        }

        public Contact Get(Func<Contact, bool> where)
        {
            throw new NotImplementedException();
        }

        public Contact GetFirst(Func<Contact, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> GetMany(Func<Contact, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Contact> GetManyQueryable(Func<Contact, bool> where)
        {
            throw new NotImplementedException();
        }

        public Contact GetSingle(Func<Contact, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Contact> GetWithInclude(Expression<Func<Contact, bool>> predicate, params string[] include)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
