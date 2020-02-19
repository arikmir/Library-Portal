using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace LibraryPortal.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Author { get; set; }
        public string ItemType { get; set; }
        public ICollection<ItemRequest> ItemRequests { get; set; }
        public ICollection<CheckedOutTable> CheckOuts { get; set; }
    }

}