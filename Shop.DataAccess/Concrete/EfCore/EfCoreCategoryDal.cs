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
    public class EfCoreCategoryDal : EfCoreGenericRepository<Category, ShopContext>, ICategoryDal
    {
        public void DeleteFromCategory(int categoryId, int productId)
        {
            using (var context = new ShopContext())
            {
                var cmd = @"delete from ProductCategories where ProductId=@p0 And CategoryId=@p1 ";
                context.Database.ExecuteSqlRaw(cmd,productId,categoryId);
            }
        }

        public Category GetByIdWithProducts(int id)
        {
            using (var context = new ShopContext())
            {
                return context.Categories.Where(i => i.Id == id)
                                .Include(i => i.ProductCategories)
                                .ThenInclude(i => i.Product)
                                .FirstOrDefault();
            }
        }
    }
}
