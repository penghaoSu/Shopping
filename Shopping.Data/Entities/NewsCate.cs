﻿using System;
using System.Collections.Generic;

namespace Shopping.Data
{
    public partial class NewsCate
    {
        public NewsCate()
        {
            News = new HashSet<News>();
        }

        public int Id { get; set; }
        public string CateName { get; set; }

        public ICollection<News> News { get; set; }
    }
}
