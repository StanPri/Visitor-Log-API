//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated from the Entity.tt T4 template.
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
    public partial class VisitorDetailEntity
    {
    
        [DataMember()]
        public int VisitID { get; set; }
    
        [DataMember()]
        public byte VisitorNo { get; set; }
    
        [DataMember()]
        public System.DateTime VisitDate { get; set; }
    
        [DataMember()]
        public Nullable<System.DateTime> CheckInTime { get; set; }
    
        [DataMember()]
        public Nullable<System.DateTime> CheckOutTime { get; set; }
    
        [DataMember()]
        public string EquipmentInfo { get; set; }
    
        [DataMember()]
        public string BadgeNo { get; set; }
    
    }
    
}