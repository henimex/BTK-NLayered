using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete
{
    class NorthwindContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
