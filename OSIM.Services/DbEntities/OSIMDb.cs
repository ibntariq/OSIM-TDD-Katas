using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSIM.Common.Models;

namespace OSIM.Services.DbEntities
{
    public class OSIMDb : DbContext
    {
        public OSIMDb() : base("OSIMDb")
        {
                
        }

        public DbSet<Item> Items { get; set; }
    }
}
