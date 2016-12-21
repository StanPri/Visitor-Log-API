using System.Collections.Generic;
using VL.Business.Entities;


namespace VL.Business.Services.Interface
{
    public interface IContactService
    {
        #region Contact
        ContactDTO GetContactByID(int contactID);
        IEnumerable<ContactDTO> GetAllContacts();
        int CreateContact(ContactDTO contactDTO);
        bool UpdateContact(int contactID, ContactDTO contactDTO);
        bool DeleteContact(int contactID);
        #endregion
    }
}
