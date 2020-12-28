using Shop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
    }
}
