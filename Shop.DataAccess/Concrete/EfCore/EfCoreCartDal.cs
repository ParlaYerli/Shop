using Shop.DataAccess.Abstract;
using Shop.DataAccess.Concrete.EfCore;
using Shop.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.DataAccess.Concrete.EfCore
{
    public class EfCoreCartDal : EfCoreGenericRepository<Cart, ShopContext> , ICartDal
    {
    }
}
