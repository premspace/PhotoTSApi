﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhotonTSapi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class photontsEntities : DbContext
    {
        public photontsEntities()
            : base("name=photontsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<project> projects { get; set; }
        public virtual DbSet<session> sessions { get; set; }
        public virtual DbSet<timesheet> timesheets { get; set; }
        public virtual DbSet<timeunit> timeunits { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
