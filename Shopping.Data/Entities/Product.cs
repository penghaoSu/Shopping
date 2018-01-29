using System;
using System.Collections.Generic;

namespace Shopping.Data
{
    public partial class Product
    {
        public Product()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string ProductNumber { get; set; }
        public int ProductCateId { get; set; }
        public string ProductName { get; set; }
        public int UnitId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Storage { get; set; }
        public string Description { get; set; }
        public bool OnShelf { get; set; }
        public string Package { get; set; }
        public string ImagePath { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }

        public ProductCate ProductCate { get; set; }
        public Unit Unit { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
