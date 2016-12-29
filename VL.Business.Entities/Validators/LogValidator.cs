using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VL.Data.Model;

namespace VL.Business.Entities
{
    public partial class LogDTO : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.StartDate.HasValue && this.EndDate.HasValue)
            {
                DateTime start = Convert.ToDateTime(this.StartDate);
                DateTime end = Convert.ToDateTime(this.EndDate);
                if (start > end) yield return new ValidationResult("Start Date cannot be after End Date", new[] {"StartDate","EndDate" });
            }
        }

    }
}
