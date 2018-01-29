using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.Service.Models
{
    public class ProductViewModel
    {

    }

    public class ProductCreateViewModel
    {

        public ProductModel Product { get; set; }

        public IEnumerable<SelectListItem> ProductCate { get; set; }

        public IEnumerable<SelectListItem> Unit { get; set; }
    }
}
