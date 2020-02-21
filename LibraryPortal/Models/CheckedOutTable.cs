using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace LibraryPortal.Models
{
    public class CheckedOutTable
    {
        public int CheckedOutId { get; set; }
        public int ItemId { get; set; }
        public System.DateTime CheckedOutDate { get; set; }
        public System.DateTime ReturnDate { get; set; }
        public string CheckedOutBy { get; set; }
        public Item Item { get; set; }
    }
}