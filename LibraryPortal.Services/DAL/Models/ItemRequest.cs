using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace LibraryPortal.Services.DAL.Models
{
    public partial class ItemRequest
    {
        [Key]
        public int RequestId { get; set; }
        public int ItemId { get; set; }
        public string RequestUserId { get; set; }
        public System.DateTime RequestedDate { get; set; }
        public virtual Item Item { get; set; }
    }

    class ItemRequestsMap : EntityTypeConfiguration<ItemRequest>
    {
        public ItemRequestsMap()
        {
            // Primary Key
            this.HasKey(t => t.RequestId);

            // Properties
            this.Property(t => t.RequestId)
                .HasColumnName("RequestId");

            // Table & Column Mappings
            this.ToTable("ItemRequests");

            // Relationships
            this.HasRequired(t => t.Item)
                .WithMany(t => t.ItemRequests)
                .HasForeignKey(d => d.ItemId);
        }
    }
}