using LibraryPortal.Services.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibraryPortal.Services.DAL
{
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
            Database.SetInitializer<Entities>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ItemsMap());
            modelBuilder.Configurations.Add(new ItemRequestsMap());
            modelBuilder.Configurations.Add(new CheckedOutTableMap());
        }

        public virtual DbSet<CheckedOutTable> CheckedOutTables { get; set; }
        public virtual DbSet<ItemRequest> ItemRequests { get; set; }
        public virtual DbSet<Item> Items { get; set; }
    }
}