using System;
using System.Collections.Generic;

namespace Shopping.Data
{
    public partial class Unit
    {
        public Unit()
        {
            Product = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string UnitName { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
