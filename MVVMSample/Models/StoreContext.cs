using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVVMSample.Models
{

    public class StoreContext : DbContext
    {
        public DbSet<Employee> Employees {get; set;}
    }
}