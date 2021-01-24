using Shop.Business.Abstract;
using Shop.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Business.Concrete
{
    public class CartManager : ICartService
    {
        public ICartDal _cartDal;

        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

       
    }
}
