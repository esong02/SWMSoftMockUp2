//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerClient.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssetSite
    {
        public int Id { get; set; }
        public string Function { get; set; }
        public string AcessDescription { get; set; }
        public bool OpenAccess { get; set; }
        public string Parking { get; set; }
    
        public virtual Asset Asset { get; set; }
        public virtual FacilityFunction FacilityFunction { get; set; }
    }
}
