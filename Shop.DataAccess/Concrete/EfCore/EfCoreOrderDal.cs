using Shop.DataAccess.Abstract;
using Shop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DataAccess.Concrete.EfCore
{
    public class EfCoreOrderDal:EfCoreGenericRepository<Order,ShopContext>, IOrderDal
    {
    }
}
