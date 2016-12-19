using System.Collections.Generic;
using VL.Business.Entities;


namespace VL.Business.Services.Interface
{
    public interface IContactService
    {
        ContactDTO GetContactByID(int contactID);
        IEnumerable<ContactDTO> GetAllContactss();
        int CreateContact(ContactDTO contactDTO);
        bool UpdateContact(int contactID, ContactDTO contactDTO);
        bool DeleteContact(int contactID);
    }
}
