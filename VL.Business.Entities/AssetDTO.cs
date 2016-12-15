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
    public partial class AssetDTO
    {
        
        public AssetDTO()
        {
            this.AssetTypeAssets = new List<AssetTypeAssetDTO>();
            this.VisitorVisits = new List<VisitorVisitDTO>();
        }
    
    
        [DataMember()]
        public int ID { get; set; }
    
        [DataMember()]
        public string Name { get; set; }
    
        [DataMember()]
        public string CreatedByUserID { get; set; }
    
        [DataMember()]
        public System.DateTime CreateDate { get; set; }
    
        [DataMember()]
        public string ModifiedByUserID { get; set; }
    
        [DataMember()]
        public System.DateTime ModifiedDate { get; set; }
    
        #region [Navigation Properties]
    
        [DataMember()]
        public List<AssetTypeAssetDTO> AssetTypeAssets { get; set; }
    
        [DataMember()]
        public List<VisitorVisitDTO> VisitorVisits { get; set; }
                
        #endregion [Navigation Properties]
    
    }
    
}