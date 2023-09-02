using Logistics.Data.DTO.Order;
using Logistics.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Service.Interfaces
{
    public interface IOrderDetailService
    {
        List<OrderDetail> GetAllOrderDetailByOrderId(string orderId);
        bool CreateOrderDetail(OrderItem order);
        bool DeleteOrderDetail(OrderDetail order);
    }
}
