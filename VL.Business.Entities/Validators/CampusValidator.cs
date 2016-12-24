using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using VL.Data.Model;

namespace VL.Business.Entities
{
    public partial class CampusDTO : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //Validate object Property State
            if (string.IsNullOrWhiteSpace(this.Name)) yield return new ValidationResult("Name cannot be empty", new[] { "Name" });
            if (string.IsNullOrWhiteSpace(this.City)) yield return new ValidationResult("City cannot be empty", new[] { "City" });
            if (string.IsNullOrWhiteSpace(this.Address)) yield return new ValidationResult("Address cannot be empty", new[] { "Address" });
            if (string.IsNullOrWhiteSpace(this.ZipCode)) yield return new ValidationResult("Zipcode cannot be empty", new[] { "ZipCode" });
        }
    }
}
