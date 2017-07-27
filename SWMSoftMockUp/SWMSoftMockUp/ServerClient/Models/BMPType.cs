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
    
    public partial class BMPType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BMPType()
        {
            this.LIDs = new HashSet<LID>();
            this.LIDComponentIndicatorTemplates = new HashSet<LIDComponentIndicatorTemplate>();
            this.LIDComponents = new HashSet<LIDComponent>();
            this.LIDComponentTemplates = new HashSet<LIDComponentTemplate>();
            this.LIDDesignTypes = new HashSet<LIDDesignType>();
        }
    
        public string Code { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LID> LIDs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIDComponentIndicatorTemplate> LIDComponentIndicatorTemplates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIDComponent> LIDComponents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIDComponentTemplate> LIDComponentTemplates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIDDesignType> LIDDesignTypes { get; set; }
    }
}
