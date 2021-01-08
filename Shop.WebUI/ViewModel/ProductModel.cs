using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebUI.ViewModel
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
    }
}
