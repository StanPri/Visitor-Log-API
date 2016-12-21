using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VL.Data.Model;

namespace VL.Business.Entities
{
    public partial class AssetDTO : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //Validate object Property State
            if (string.IsNullOrWhiteSpace(this.Name)) yield return new ValidationResult("Name cannot be empty", new[] { "Name" });
            //Validate object Database State
            IUnitOfWork uow = new UnitOfWork();
            var assetDTOs = uow.AssetRepository.Get(a => a.Name.ToUpper() == this.Name.ToUpper());
            if (assetDTOs != null) yield return new ValidationResult("Name already exists", new[] { "Name" });
        }
    }
}
