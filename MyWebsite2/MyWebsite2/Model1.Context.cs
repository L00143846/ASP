﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EquipMaintSys1Entities1 : DbContext
    {
        public EquipMaintSys1Entities1()
            : base("name=EquipMaintSys1Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Component> Components { get; set; }
        public virtual DbSet<Contractor> Contractors { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee_Login> Employee_Login { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }
        public virtual DbSet<Fault_Log> Fault_Log { get; set; }
        public virtual DbSet<Maintenance_Schedule> Maintenance_Schedule { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Syslog> Syslogs { get; set; }
    }
}
