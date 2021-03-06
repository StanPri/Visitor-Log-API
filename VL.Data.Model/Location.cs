//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VL.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Location()
        {
            this.CampusLocations = new HashSet<CampusLocation>();
            this.LocationHistories = new HashSet<LocationHistory>();
            this.LogVisitors = new HashSet<LogVisitor>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }
        public string Room { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public string CreatedByUserID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedByUserID { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CampusLocation> CampusLocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationHistory> LocationHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LogVisitor> LogVisitors { get; set; }
    }
}
