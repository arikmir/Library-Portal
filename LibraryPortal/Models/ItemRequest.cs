using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace LibraryPortal.Models
{
    public class ItemRequest
    {
        public int RequestId { get; set; }
        public int ItemId { get; set; }
        public string RequestUserId { get; set; }
        public System.DateTime RequestedDate { get; set; }
        public Item Item { get; set; }
    }

}