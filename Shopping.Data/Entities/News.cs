using System;
using System.Collections.Generic;

namespace Shopping.Data
{
    public partial class News
    {
        public int Id { get; set; }
        public int NewsCateId { get; set; }
        public string Title { get; set; }
        public string NewsContent { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }

        public NewsCate NewsCate { get; set; }
    }
}
