using Shop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetPopularProducts();
        Product GetById(int id);
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}
