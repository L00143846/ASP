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
    
    public partial class Employee_Login
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee_Login()
        {
            this.Syslogs = new HashSet<Syslog>();
        }
    
        public int LogID { get; set; }
        public Nullable<int> UserID { get; set; }
        public System.DateTime Login_Timestamp { get; set; }
        public Nullable<System.DateTime> Logout_Timestamp { get; set; }
    
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Syslog> Syslogs { get; set; }
    }
}