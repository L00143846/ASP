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
    
    public partial class Fault_Log
    {
        public int IncindentID { get; set; }
        public string Start_Time { get; set; }
        public string End_Time { get; set; }
        public bool Downtime { get; set; }
        public string Equipment { get; set; }
        public string Component { get; set; }
        public Nullable<int> Employee { get; set; }
        public string Contractor { get; set; }
        public string Description { get; set; }
    
        public virtual Component Component1 { get; set; }
        public virtual Contractor Contractor1 { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual Equipment Equipment1 { get; set; }
    }
}