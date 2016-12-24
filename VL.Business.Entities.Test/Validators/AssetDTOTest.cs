using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace VL.Business.Entities.Test.Validators
{
    /// <summary>
    /// Implements unit tests for <see cref="VL.Business.Entities.AssetDTO"/>
    /// </summary>
    public class AssetDTOTest
    {
        private AssetDTO _assetDTO;

        #region Constructor - Setup
        public AssetDTOTest()
        {
            _assetDTO = new AssetDTO { Name = "Sony VAIO Laptop" };
        }
        #endregion

        [Fact]
        public void WhenAllRequiredFieldsPresent_AssertValid()
        {
            var validationResults = _assetDTO.Validate(null);
            Assert.False(validationResults.Any());
        }

        [Fact]
        public void WhenMissingName_AssertError()
        {
            _assetDTO.Name = null;
            var validationResults = _assetDTO.Validate(null);
            Assert.NotNull(validationResults.Single());
        }
    }
}
