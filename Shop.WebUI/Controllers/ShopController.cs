using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Business.Abstract;
using Shop.Entities;
using Shop.WebUI.ViewModel;

namespace Shop.WebUI.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ShopController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult List()
        {
            return View(new ProductListModel()
            {
                Products = _productService.GetAll()
            });
        }
        public IActionResult Details(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Product product = _productService.GetById((int)id);
            if (product==null)
            {
                return NotFound();
            }
            return View(product);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
