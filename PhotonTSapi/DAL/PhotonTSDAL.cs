using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MySql.Data.Entity;
using PhotonTSapi.Models;


namespace PhotonTSapi.DAL
{
    public class PhotonTSDAL: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<user>().ToTable("user");
            modelBuilder.Entity<project>().ToTable("project");
            modelBuilder.Entity<session>().ToTable("session");
            modelBuilder.Entity<timesheet>().ToTable("timesheet");
            modelBuilder.Entity<timeunit>().ToTable("timeunit");

        }

        public DbSet<user> users { get; set; }
        public DbSet<project> projects { get; set; }
        public DbSet<session> sessions { get; set; }
        public DbSet<timesheet> timesheets { get; set; }
        public DbSet<timeunit> timeunits { get; set; }


    }
}