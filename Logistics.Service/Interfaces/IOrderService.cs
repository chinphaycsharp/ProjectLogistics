﻿using Logistics.Data.DTO.Order;
using Logistics.Data.Entities;
using Logistics.Service.Commons;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logistics.Service.Interfaces
{
    public interface IOrderService
    {
        Task<PaginatedList<Order>> GetOrders(OrderSearchDTO orderSearchDTO);
        Order GetOrderById(string id);
        bool CreateOrder(OrderCreateDTO order);
        bool UpdateStatus();
    }
}
