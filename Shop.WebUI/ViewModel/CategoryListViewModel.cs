using Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebUI.ViewModel
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public string SelectedCategory { get; set; }
    }
}
