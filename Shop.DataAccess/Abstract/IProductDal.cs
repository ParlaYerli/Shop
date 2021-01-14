﻿using Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Shop.DataAccess.Abstract
{
    public interface IProductDal : IRepository<Product>
    {
        Product GetProductDetails(int id);
        List<Product> GetProductsByCategory(string category,int page, int pageSize);
        int GetCountByCategory(string category);
        Product GetByIdWithCategories(int id);
    }
}
