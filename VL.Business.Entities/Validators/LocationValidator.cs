﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using VL.Data.Model;

namespace VL.Business.Entities
{
    public partial class LocationDTO : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrEmpty(this.Name)) yield return new ValidationResult("Name cannot be empty", new[] { "Name" });
        }
    }
}
