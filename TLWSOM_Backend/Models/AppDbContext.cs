using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleWoodshopDB
{
    class WSDbContext : DbContext
    {
        public WSDbContext() : base()
        {

        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Order { get; set; }
    }
}
