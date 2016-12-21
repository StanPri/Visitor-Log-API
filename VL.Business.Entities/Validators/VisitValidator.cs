using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VL.Business.Entities
{
    public partial class VisitDTO : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //Validate object Property State
            if (this.ScheduledCheckInTime < this.ScheduledCheckOutTime) yield return new ValidationResult("Scheduled check-in time cannot be after scheduled check-out time", new[] {"ScheduledCheckInTime", "ScheduledCheckOutTime" });
            if(this.ActualCheckInTime.HasValue && this.ActualCheckOutTime.HasValue)
            {
                if(Convert.ToDateTime(this.ActualCheckInTime) < Convert.ToDateTime(this.ActualCheckOutTime)) yield return new ValidationResult("Actual check-in time cannot be after actual check-out time", new[] { "ActualCheckInTime", "ActualCheckOutTime" });
            }
        }
    }
}
