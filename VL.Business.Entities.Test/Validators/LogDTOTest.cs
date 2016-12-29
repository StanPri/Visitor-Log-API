using System;
using System.Linq;
using Xunit;

namespace VL.Business.Entities.Test.Validators
{
    public class LogDTOTest
    {
        private LogDTO _logDTO;

        #region Constructor - Setup
        public LogDTOTest()
        {
            DateTime currentTime = DateTime.Now;

            _logDTO = new LogDTO() { StartDate = currentTime, EndDate = currentTime.AddHours(4), Reason = "Testing the Reason", SpecialInstructions = "Testing the Special Instructions", CreatedByUserID = "mickey.mouse"  };
        }
        #endregion

        [Fact]
        public void WhenAllRequiredFieldsPresent_AssertValid()
        {
            var validationResults = _logDTO.Validate(null);
            Assert.False(validationResults.Any());
        }

        //[Fact]
        //public void WhenMissingStartDate_AssertError()
        //{
        //    _logDTO.StartDate = null;
        //    var validationResults = _logDTO.Validate(null);
        //    Assert.NotNull(validationResults.Single());
        //}

        [Fact]
        public void WhenStartDateIsAfterEndDate_AssertError()
        {
            DateTime startDate = DateTime.Now;
            DateTime endDate = startDate.AddDays(-1);
            _logDTO.StartDate = startDate;
            _logDTO.EndDate = endDate;

            var validationResults = _logDTO.Validate(null);
            Assert.NotNull(validationResults.Single());

        }

    }
}
