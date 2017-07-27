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
    
    public partial class Maintenance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Maintenance()
        {
            this.ComponentPictures = new HashSet<ComponentPicture>();
            this.LIDComponentPictures = new HashSet<LIDComponentPicture>();
            this.MaintenanceResources = new HashSet<MaintenanceResource>();
        }
    
        public int Id { get; set; }
        public Nullable<int> InspectionId { get; set; }
        public Nullable<int> LIDInspectionId { get; set; }
        public string Task { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string RequestedBy { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public Nullable<int> Reminder { get; set; }
        public Nullable<System.DateTime> ClosedDate { get; set; }
        public string ClosedBy { get; set; }
        public Nullable<System.DateTime> ClosedStartDate { get; set; }
        public Nullable<System.DateTime> ClosedEndDate { get; set; }
        public Nullable<decimal> ClosedBudgetCost { get; set; }
        public Nullable<decimal> ClosedFinalCost { get; set; }
        public string ClosedComments { get; set; }
        public Nullable<int> ComponentPictureId { get; set; }
        public Nullable<int> LIDComponentPictureId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComponentPicture> ComponentPictures { get; set; }
        public virtual ComponentPicture ComponentPicture { get; set; }
        public virtual Inspection Inspection { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIDComponentPicture> LIDComponentPictures { get; set; }
        public virtual LIDPastInspection LIDPastInspection { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaintenanceResource> MaintenanceResources { get; set; }
        public virtual MaintenanceStatu MaintenanceStatu { get; set; }
        public virtual MaintenanceType MaintenanceType { get; set; }
        public virtual LIDComponentPicture LIDComponentPicture { get; set; }
        public virtual LIDComponentPicture LIDComponentPicture1 { get; set; }
        public virtual LIDComponentPicture LIDComponentPicture2 { get; set; }
        public virtual LIDComponentPicture LIDComponentPicture3 { get; set; }
        public virtual LIDComponentPicture LIDComponentPicture4 { get; set; }
    }
}
