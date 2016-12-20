using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using VL.Business.Entities;
using VL.Business.Services.Mapper;
using VL.Data.Model;

namespace VL.Business.Services.Implementation
{
    public class ContactService : Interface.IContactService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int CreateContact(ContactDTO contactDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeleteContact(int contactID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ContactDTO> GetAllContacts()
        {
            var contacts = _unitOfWork.ContactRepository.GetAll();
            if (contacts.Any()) return contacts.ToDTOs();
            return null;
        }

        public ContactDTO GetContactByID(int contactID)
        {
            var contact = _unitOfWork.ContactRepository.GetByID(contactID);
            if (contact != null) return contact.ToDTO();
            return null;
        }

        public bool UpdateContact(int contactID, ContactDTO contactDTO)
        {
            throw new NotImplementedException();
        }
    }
}
