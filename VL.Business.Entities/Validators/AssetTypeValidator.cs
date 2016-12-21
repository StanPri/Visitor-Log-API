using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VL.Data.Model;

namespace VL.Business.Entities
{
    public partial class AssetTypeDTO : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //Validate object Property State
            if (string.IsNullOrWhiteSpace(this.Code)) yield return new ValidationResult("Code cannot be empty", new[] { "Code" });
            if (string.IsNullOrWhiteSpace(this.Name)) yield return new ValidationResult("Name cannot be empty", new[] { "Name" });
            //Validate object Database State
            IUnitOfWork uow = new UnitOfWork();
            var assetTypeDTO = uow.AssetTypeHistoryRepository.Get(at => at.Code.ToUpper() == this.Code.ToUpper() || at.Name.ToUpper() == this.Name.ToUpper());
            if(assetTypeDTO != null)
            {
                if (assetTypeDTO.Code.ToUpper() == this.Code.ToUpper()) yield return new ValidationResult("Code already exists.", new[] { "Code" });
                if (assetTypeDTO.Name.ToUpper() == this.Name.ToUpper()) yield return new ValidationResult("Name already exists.", new[] { "Name" });
            }
        }
    }
}
