﻿using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Interface
{
    public interface ICategoryManager
    {
        List<Category> GetAllCategories();
    }
}
