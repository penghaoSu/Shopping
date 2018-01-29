using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.Service.Models
{
    public class ProductCateViewModel
    {
        public IEnumerable<ProductCateModel> ProductCateModel { get; set; }

        public ProductCateCreateModel ProductCateCreate { get; set; }
    }

    public class ProductCateModel
    {
        public int Id { get; set; }
        public string CateName { get; set; }
    }

    public class UnitModel
    {
        public int Id { get; set; }
        public string UnitName { get; set; }
    }

    public class ProductCateCreateModel
    {
        public string CateName { get; set; }
    }
}
