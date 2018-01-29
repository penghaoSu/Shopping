using System;
using System.Collections.Generic;

namespace Shopping.Data
{
    public partial class ProductCate
    {
        public ProductCate()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string CateName { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
