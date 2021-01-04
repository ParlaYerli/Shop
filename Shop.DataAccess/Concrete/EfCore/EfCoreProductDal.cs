using Microsoft.EntityFrameworkCore;
using Shop.DataAccess.Abstract;
using Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Shop.DataAccess.Concrete.EfCore
{
    public class EfCoreProductDal : EfCoreGenericRepository<Product, ShopContext>, IProductDal
    {
        public IEnumerable<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }
        public Product GetProductDetails(int id)
        {
            using (var context = new ShopContext())
            {
                return context.Products.Where(i => i.Id == id)
                                        .Include(i => i.ProductCategories)
                                        .ThenInclude(i => i.Category)
                                        .FirstOrDefault();

            }
        }
    }
}
