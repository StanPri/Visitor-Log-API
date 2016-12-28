using System.Linq;
using Xunit;

namespace VL.Business.Entities.Test.Validators
{
    /// <summary>
    /// Implements unit tests for <see cref="VL.Business.Entities.AssetTypeDTO"/>
    /// </summary>
    public class AssetTypeDTOTest
    {

        private AssetTypeDTO _assetTypeDTO;

        #region Constructor - Setup
        public AssetTypeDTOTest()
        {
            _assetTypeDTO = new AssetTypeDTO { Name = "Cell Phone" };
        }
        #endregion

        [Fact]
        public void WhenAllRequiredFieldsPresent_AssertValid()
        {
            var validationResults = _assetTypeDTO.Validate(null);
            Assert.False(validationResults.Any());
        }

        [Fact]
        public void WhenMissingName_AssertError()
        {
            _assetTypeDTO.Name = null;
            var validationResults = _assetTypeDTO.Validate(null);
            Assert.NotNull(validationResults.Single());
        }

    }
}
