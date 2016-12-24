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
    /// Implements unit tests for <see cref="VL.Business.Entities.CampusDTO"/>
    /// </summary>
    public class CampusDTOTest
    {
        private CampusDTO _campusDto;

        public CampusDTOTest()
        {
            _campusDto = new CampusDTO { Name = "Name", City = "City", Address = "Address", ZipCode = "ZipCode" };
        }

        [Fact]
        public void WhenAllRequiredFieldsPresent_AssertValid()
        {
            var validationResults = _campusDto.Validate(null);
            Assert.False(validationResults.Any());
        }

        [Fact]
        public void WhenMissingName_AssertError()
        {
            _campusDto.Name = null;
            var validationResults = _campusDto.Validate(null);
            Assert.NotNull(validationResults.Single());
        }

        [Fact]
        public void WhenMissingCity_AssertError()
        {
            _campusDto.City = null;
            var validationResults = _campusDto.Validate(null);
            Assert.NotNull(validationResults.Single());
        }

        [Fact]
        public void WhenMissingAddress_AssertError()
        {
            _campusDto.Address = null;
            var validationResults = _campusDto.Validate(null);
            Assert.NotNull(validationResults.Single());
        }

        [Fact]
        public void WhenMissingZip_AssertError()
        {
            _campusDto.ZipCode = null;
            var validationResults = _campusDto.Validate(null);
            Assert.NotNull(validationResults.Single());
        }
    }
}
