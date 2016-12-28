using System.Linq;
using Xunit;


namespace VL.Business.Entities.Test.Validators
{
    /// <summary>
    /// Implements unit tests for <see cref="VL.Business.Entities.CompanyDTO"/>
    /// </summary>
    public class CompanyDTOTest
    {
        private CompanyDTO _companyDTO;

        #region Constructor - Setup
        public CompanyDTOTest()
        {
            _companyDTO = new CompanyDTO() { Name = "Microsoft" };
        }
        #endregion

        [Fact]
        public void WhenAllRequiredFieldsPresent_AssertValid()
        {
            var validationResults = _companyDTO.Validate(null);
            Assert.False(validationResults.Any());
        }

        [Fact]
        public void WhenMissingName_AssertError()
        {
            _companyDTO.Name = null;
            var validationResults = _companyDTO.Validate(null);
            Assert.NotNull(validationResults.Single());
        }
    }
}
