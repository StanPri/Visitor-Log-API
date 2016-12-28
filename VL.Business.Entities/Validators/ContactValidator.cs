using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace VL.Business.Entities
{
    /// <summary>
    /// Implements unit tests for <see cref="VL.Business.Entities.ContactDTO"/>
    /// </summary>
    public partial class ContactDTO : IValidatableObject
    {

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //Regex pattern for phone
            //Matches: 15615552323 or 1-561-555-1212 or 5613333
            Regex rgx = new Regex(@"^(1?(-?\d{3})-?)?(\d{3})(-?\d{4})$");
            
            //Validate Contact User ID
            if (string.IsNullOrWhiteSpace(this.ContactUserID)) yield return new ValidationResult("User cannot be empty", new[] { "ContactUserID" });
            //Validate Phone Number
            if (string.IsNullOrWhiteSpace(this.Phone)) yield return new ValidationResult("Phone cannot be empty", new[] { "Phone" });
            else
                if (!rgx.IsMatch(this.Phone))
                    yield return new ValidationResult("Phone must be in proper US 10 digit format", new[] { "Phone" });
            //Validate Mobile, if available
            if(!string.IsNullOrWhiteSpace(this.Mobile))
                if (!rgx.IsMatch(this.Mobile))
                    yield return new ValidationResult("Mobile must be in proper US 10 digit format", new[] { "Mobile" });
        }
    }
}
