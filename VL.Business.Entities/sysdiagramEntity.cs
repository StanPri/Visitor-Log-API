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
    public partial class sysdiagramEntity
    {
    
        [DataMember()]
        public string name { get; set; }
    
        [DataMember()]
        public int principal_id { get; set; }
    
        [DataMember()]
        public int diagram_id { get; set; }
    
        [DataMember()]
        public Nullable<int> version { get; set; }
    
        [DataMember()]
        public byte[] definition { get; set; }
    
    }
    
}