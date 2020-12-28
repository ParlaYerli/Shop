using Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Shop.DataAccess.Abstract
{
    public interface IProductDal : IRepository<Product>
    {
        IEnumerable<Product> GetPopularProducts();
    }
}
