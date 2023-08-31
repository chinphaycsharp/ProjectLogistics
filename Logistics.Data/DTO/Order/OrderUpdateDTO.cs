using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Data.DTO.Order
{
    public class OrderUpdateDTO
    {
        public string Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime? EstimateDeliveryDate { get; set; }
        public bool? Status { get; set; }
        public bool? Isdeleted { get; set; }
    }
}
