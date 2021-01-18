using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal? Price { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
