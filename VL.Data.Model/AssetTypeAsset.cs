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
    
    public partial class AssetTypeAsset
    {
        public int AssetTypeID { get; set; }
        public int AssetID { get; set; }
        public string CreatedByUserID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedByUserID { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Asset Asset { get; set; }
        public virtual AssetType AssetType { get; set; }
    }
}
