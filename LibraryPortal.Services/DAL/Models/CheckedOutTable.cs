using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace LibraryPortal.Services.DAL.Models
{
    public partial class CheckedOutTable
    {
        [Key]
        public int CheckedOutId { get; set; }
        public int ItemId { get; set; }
        public System.DateTime CheckedOutDate { get; set; }
        public System.DateTime ReturnDate { get; set; }
        public string CheckedOutBy { get; set; }
        public Item Item { get; set; }
    }

    class CheckedOutTableMap : EntityTypeConfiguration<CheckedOutTable>
    {
        public CheckedOutTableMap()
        {
            // Primary Key
            this.HasKey(t => t.CheckedOutId);

            // Properties
          
            // Table & Column Mappings
            this.ToTable("CheckedOutTable");

            // Relationships
            this.HasRequired(t => t.Item)
                .WithMany(t => t.CheckOuts)
                .HasForeignKey(d => d.ItemId);
        }
    }
}