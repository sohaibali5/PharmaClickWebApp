using PharmaClick.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaClick.Database
{
    public class PCcontext:DbContext
    {
        public PCcontext():base("PharmaClickConnection")
        {

        }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
