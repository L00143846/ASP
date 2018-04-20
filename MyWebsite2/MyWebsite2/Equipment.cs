//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWebsite2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipment()
        {
            this.Components = new HashSet<Component>();
            this.Fault_Log = new HashSet<Fault_Log>();
            this.Maintenance_Schedule = new HashSet<Maintenance_Schedule>();
        }
    
        public string SerialID { get; set; }
        public string Name { get; set; }
        public string Supplier { get; set; }
        public string Contractor { get; set; }
        public string Downtime_cost_hr { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Purchase_Cost { get; set; }
        public string Purchase_Date { get; set; }
        public string Expected_Lifetime { get; set; }
        public string End_of_Warranty { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Component> Components { get; set; }
        public virtual Contractor Contractor1 { get; set; }
        public virtual Supplier Supplier1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fault_Log> Fault_Log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maintenance_Schedule> Maintenance_Schedule { get; set; }
    }
}
