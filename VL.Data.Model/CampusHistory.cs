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
    
    public partial class CampusHistory
    {
        public int ID { get; set; }
        public int CampusID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public bool IsActive { get; set; }
        public string ModifiedByUserID { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public System.DateTime AuditDate { get; set; }
    }
}
