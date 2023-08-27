using System;
using System.Collections.Generic;

#nullable disable

namespace Logistics.Data.Entities
{
    public partial class VTopOrderMaxPrice
    {
        public string Id { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? Quantity { get; set; }
        public bool? Status { get; set; }
    }
}
