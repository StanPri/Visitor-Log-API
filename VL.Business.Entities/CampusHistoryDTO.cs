//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated from the DTO.tt T4 template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//  Author: Henry Rodriguez
// </auto-generated>
//------------------------------------------------------------------------------

namespace VL.Business.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    
    
    [DataContract(IsReference=true)]
    public partial class CampusHistoryDTO
    {
    
        [DataMember()]
        public int ID { get; set; }
    
        [DataMember()]
        public int CampusID { get; set; }
    
        [DataMember()]
        public string Code { get; set; }
    
        [DataMember()]
        public string Name { get; set; }
    
        [DataMember()]
        public string Address { get; set; }
    
        [DataMember()]
        public string Address2 { get; set; }
    
        [DataMember()]
        public string City { get; set; }
    
        [DataMember()]
        public string ZipCode { get; set; }
    
        [DataMember()]
        public bool IsActive { get; set; }
    
        [DataMember()]
        public string ModifiedByUserID { get; set; }
    
        [DataMember()]
        public System.DateTime ModifiedDate { get; set; }
    
        [DataMember()]
        public System.DateTime AuditDate { get; set; }
    
    }
    
}
