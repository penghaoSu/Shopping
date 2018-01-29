using System;
using System.Collections.Generic;

namespace Shopping.Data
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Question { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
