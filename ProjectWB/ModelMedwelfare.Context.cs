﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectWB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MedwelfareEntities1 : DbContext
    {
        public MedwelfareEntities1()
            : base("name=MedwelfareEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accountant> Accountant { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Evidence> Evidence { get; set; }
        public virtual DbSet<Executive> Executive { get; set; }
        public virtual DbSet<HR> HR { get; set; }
        public virtual DbSet<MoneyTransferStatus> MoneyTransferStatus { get; set; }
        public virtual DbSet<RightEmp> RightEmp { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
