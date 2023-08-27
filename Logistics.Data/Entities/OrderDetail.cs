using System;
using System.Collections.Generic;

#nullable disable

namespace Logistics.Data.Entities
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public string OrderId { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
