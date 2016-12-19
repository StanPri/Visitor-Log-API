﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using VL.Data.Model;

namespace VL.Business.Entities
{
    public partial class CampusDTO : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //Validate object Property State
            if (string.IsNullOrWhiteSpace(this.Code)) yield return new ValidationResult("Code cannot be empty", new[] { "Code" });
            if (string.IsNullOrWhiteSpace(this.Name)) yield return new ValidationResult("Name cannot be empty", new[] { "Name" });
            if (string.IsNullOrWhiteSpace(this.City)) yield return new ValidationResult("City cannot be empty", new[] { "City" });
            if (string.IsNullOrWhiteSpace(this.Address)) yield return new ValidationResult("Address cannot be empty", new[] { "Address" });
            if (string.IsNullOrWhiteSpace(this.ZipCode)) yield return new ValidationResult("Zipcode cannot be empty", new[] { "ZipCode" });
            //Validate object Database State
            IUnitOfWork uow = new UnitOfWork();
            var campusDTO = uow.CampusRepository.Get(c => c.Code.ToUpper() == this.Code.ToUpper() || c.Name.ToUpper() == this.Name.ToUpper());
            if(campusDTO != null)
            {
                if (campusDTO.Code.ToUpper() == this.Code.ToUpper()) yield return new ValidationResult("Code already exists.", new[] { "Code" });
                if (campusDTO.Name.ToUpper() == this.Name.ToUpper()) yield return new ValidationResult("Name already exists.", new[] { "Name" });
            }
        }
    }
}