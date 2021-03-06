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
    public partial class VisitorDTO
    {
        
        public VisitorDTO()
        {
            this.LogVisits = new List<LogVisitDTO>();
            this.LogVisitors = new List<LogVisitorDTO>();
        }
    
    
        [DataMember()]
        public int ID { get; set; }
    
        [DataMember()]
        public string FirstName { get; set; }
    
        [DataMember()]
        public string LastName { get; set; }
    
        [DataMember()]
        public string PersonIDCardNumber { get; set; }
    
        [DataMember()]
        public string CreatedByUserID { get; set; }
    
        [DataMember()]
        public System.DateTime CreatedDate { get; set; }
    
        [DataMember()]
        public string ModifiedByUserID { get; set; }
    
        [DataMember()]
        public System.DateTime ModifiedDate { get; set; }
    
        #region [Navigation Properties]
    
        [DataMember()]
        public List<LogVisitDTO> LogVisits { get; set; }
    
        [DataMember()]
        public List<LogVisitorDTO> LogVisitors { get; set; }
                
        #endregion [Navigation Properties]
    
    }
    
}
