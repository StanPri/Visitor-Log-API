using System.Linq;
using Xunit;

namespace VL.Business.Entities.Test.Validators
{
    /// <summary>
    /// Implements unit tests for <see cref="VL.Business.Entities.ContactDTO"/>
    /// </summary>
    public class ContactDTOTest
    {

        private ContactDTO _contactDTO;

        #region Constructor - Setup
        public ContactDTOTest()
        {
            _contactDTO = new ContactDTO() { ContactUserID = "tony.stark", Phone = "9168675309" };
        }
        #endregion

        [Fact]
        public void WhenAllRequiredFieldsPresent_AssertValid()
        {
            var validationResults = _contactDTO.Validate(null);
            Assert.False(validationResults.Any());
        }

        [Fact]
        public void WhenMissingContactUserID_AssertError()
        {
            _contactDTO.ContactUserID = null;
            var validationResults = _contactDTO.Validate(null);
            Assert.NotNull(validationResults.Single());
        }

        [Fact]
        public void WhenMissingPhone_AssertError()
        {
            _contactDTO.Phone = null;
            var validationResults = _contactDTO.Validate(null);
            Assert.NotNull(validationResults.Single());
        }

        [Fact]
        public void WhenPhoneFormatIncorrect_AssertError()
        {
            _contactDTO.Phone = "777555888"; //6 digits, sb 7, 10, or 11
            var validationResults = _contactDTO.Validate(null);
            Assert.NotNull(validationResults.Single());
        }

        [Fact]
        public void WhenMobileFormatIncorrect_AssertError()
        {
            _contactDTO.Mobile = "777555888"; //6 digits, sb 7, 10, or 11
            var validationResults = _contactDTO.Validate(null);
            Assert.NotNull(validationResults.Single());
        }

        [Fact]
        public void WhenMobileFormatCorrect_AssertValid()
        {
            _contactDTO.Mobile = "9168675309";
            var validationResults = _contactDTO.Validate(null);
            Assert.False(validationResults.Any());
        }

        [Fact]
        public void WhenPhoneFormatCorrect_AssertValid()
        {
            _contactDTO.Mobile = "9168675309";
            var validationResults = _contactDTO.Validate(null);
            Assert.False(validationResults.Any());
        }
    }
}
