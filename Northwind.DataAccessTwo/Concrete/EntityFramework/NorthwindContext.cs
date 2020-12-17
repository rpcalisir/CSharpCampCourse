﻿using Northwind.EntitiesTwo.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccessTwo.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
