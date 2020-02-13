using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPortal.DataModels
{
    class Program
    {
        static void Main(string[] args)
        {
            Entities entities = new Entities();
            entities.Items.Add(new Item()
            {
                Item_Name = "CS Name",
                Author = "Arik",
            });
            entities.SaveChanges();
        }
    }
}
