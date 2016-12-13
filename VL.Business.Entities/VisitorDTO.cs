//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated from the DTO.tt T4 template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//  Author: Johnny Vu
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
            this.LogVisitors = new List<LogVisitorDTO>();
            this.VisitorVisits = new List<VisitorVisitDTO>();
            this.VisitorBadges = new List<VisitorBadgeDTO>();
            this.VisitorCompanies = new List<VisitorCompanyDTO>();
        }
    
    
        [DataMember()]
        public int ID { get; set; }
    
        [DataMember()]
        public string FirstName { get; set; }
    
        [DataMember()]
        public string LastName { get; set; }
    
        [DataMember()]
        public int CreatedByUserID { get; set; }
    
        [DataMember()]
        public string PersonIDCardNumber { get; set; }
    
        #region [Navigation Properties]
    
        [DataMember()]
        public List<LogVisitorDTO> LogVisitors { get; set; }
    
        [DataMember()]
        public List<VisitorVisitDTO> VisitorVisits { get; set; }
    
        [DataMember()]
        public List<VisitorBadgeDTO> VisitorBadges { get; set; }
    
        [DataMember()]
        public List<VisitorCompanyDTO> VisitorCompanies { get; set; }
                
        #endregion [Navigation Properties]
    
    }
    
}
