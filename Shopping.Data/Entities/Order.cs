using System;
using System.Collections.Generic;

namespace Shopping.Data
{
    public partial class Order
    {
        public Order()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public string UserId { get; set; }
        public decimal Amount { get; set; }
        public int Status { get; set; }
        public string Memo { get; set; }
        public string Consignee { get; set; }
        public string ConsigneeTel { get; set; }
        public string ConsigneeMobile { get; set; }
        public string ConsigneeAddress { get; set; }
        public DateTime CreateDate { get; set; }

        public AspNetUsers User { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
