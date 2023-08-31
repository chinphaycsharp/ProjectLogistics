using Logistics.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Data.DTO.Order
{
    public class OrderDetailDTO
    {
        public string Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime? EstimateDeliveryDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? Status { get; set; }
        public List<OrderItem> OrderItems{ get; set; }
    }
        
    public class OrderItem
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public decimal Price { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }
    }
}
