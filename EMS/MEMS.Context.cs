﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EMS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBEMSEntities : DbContext
    {
        public DBEMSEntities()
            : base("name=DBEMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_Employees> TB_Employees { get; set; }
        public virtual DbSet<TB_Vacations> TB_Vacations { get; set; }
        public virtual DbSet<TB_Salaries> TB_Salaries { get; set; }
        public virtual DbSet<TB_Projects> TB_Projects { get; set; }
        public virtual DbSet<TB_Tasks> TB_Tasks { get; set; }
    }
}
