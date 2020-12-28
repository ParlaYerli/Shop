using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.Entities
{
    public class ProductCategory
    {
        [ForeignKey("CategoryID")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey("ProductID")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
