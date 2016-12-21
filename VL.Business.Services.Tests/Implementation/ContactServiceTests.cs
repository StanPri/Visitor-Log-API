using System;
using System.Collections.Generic;
using System.Linq;
using VL.Business.Services.Implementation;
using VL.Business.Services.Interface;
using VL.Data.Model;
using VL.Data.Model.GenericRepository;
using VL.Tests.Helpers;
using VL.Business.Services.Mapper;
using VL.Business.Entities;

using NSubstitute;
using VL.Business.Services.Tests.Fakes.VL.Data.Model;
using Xunit;

namespace VL.Business.Services.Tests.Implementation
{
    public class ContactServiceTests
    {
        #region Variables
        private IContactService _contactService;
        private IUnitOfWork _unitOfWork;
        private ContactRepositoryFake _contactRepository;
        private VisitorLogContext _visitorLogContext;

        #endregion

        #region Constructor - Setup
        /// <summary>
        /// Re-initializes test.
        /// </summary>
        public ContactServiceTests()
        {
            _visitorLogContext = Substitute.For<VisitorLogContext>();
            _contactRepository = new ContactRepositoryFake(_visitorLogContext);
            _unitOfWork = Substitute.For<IUnitOfWork>();
            _unitOfWork.ContactRepository.Returns(_contactRepository);
            _contactService = new ContactService(_unitOfWork);
        }

        #endregion

        #region Contact Tests
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void WhenGettingContactByID_AssertReturnedContact(int id)
        {
            var contact = _contactService.GetContactByID(id);
            Asset.Equals(id, contact.ID);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public void WhenGettingContactWithInvalidID_AssertNullReturn(int id)
        {
            var contact = _contactService.GetContactByID(id);
            Assert.Null(contact);
        }

        [Fact]
        public void WhenGettingAllContacts_AssertReturnedCollection()
        {
            var contacts = _contactService.GetAllContacts();
            Assert.Equal(DataInitializer.GetAllContacts().Count, contacts.Count());
        }

        [Fact]
        public void WhenAllContactsCollectionEmpty_AssertReturnedCollectionEmpty()
        {
            //Before testing this, we need to empty what's in the repository
            _contactRepository.GetAll().ToList().ForEach(x => _contactRepository.Delete(x));
            var contacts = _contactService.GetAllContacts();
            Assert.Equal(0, contacts.Count());
        }

        #endregion

    }
}
