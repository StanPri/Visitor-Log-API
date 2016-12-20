using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VL.Business.Entities;
using VL.Business.Services.Interface;
using VL.Web.Common.Validation;

namespace VL.Web.Api.Controllers
{
    [RoutePrefix("contacts")]
    public class ContactController : ApiController
    {
        private readonly IContactService _contactService;

        #region Constructor
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        #endregion

        // GET: contacts/5
        [HttpGet]
        [Route("{id:int}", Name = "ContactByIDRoute")]
        public IHttpActionResult ContactByID(int id)
        {
            var contact = _contactService.GetContactByID(id);
            if (contact != null) return Ok(contact);
            return NotFound();
        }

        // GET: contacts
        [HttpGet]
        [Route("")]
        public IHttpActionResult AllContacts()
        {
            var contacts = _contactService.GetAllContacts();
            if (contacts != null)
            {
                var contactDTOs = contacts as List<ContactDTO> ?? contacts.ToList();
                if (contactDTOs.Any()) return Ok(contactDTOs);
            }
            return NotFound();
        }
    }
}
