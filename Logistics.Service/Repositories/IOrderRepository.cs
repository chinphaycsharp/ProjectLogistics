using Logistics.Data.DTO.Order;
using Logistics.Data.Entities;
using Logistics.Service.Commons;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using QuanLySinhVien.Service.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Service.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<PaginatedList<Order>> GetOrders(OrderSearchDTO orderSearchDTO);
        Order GetOrderById(string id);
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public Order GetOrderById(string id)
        {
            var query = from p in DbContext.Orders
                        where p.Id == id
                        select p;

            return query.FirstOrDefault();
        }

        public async Task<PaginatedList<Order>> GetOrders(OrderSearchDTO orderSearchDTO)
        {
            if (orderSearchDTO.SearchValue != null)
            {
                orderSearchDTO.PageNumber = 1;
            }
            var accounts = from s in DbContext.Orders
                           select s;
            if (!String.IsNullOrEmpty(orderSearchDTO.SearchValue))
            {
                accounts = accounts.Where(s => s.CustomerName.Contains(orderSearchDTO.SearchValue) || s.Id.Contains(orderSearchDTO.SearchValue));
            }

            if (orderSearchDTO.DateStart != null && orderSearchDTO.DateEnd != null)
            {
                accounts = accounts.Where(s => s.DeliveryDate >= orderSearchDTO.DateStart && s.DeliveryDate <= orderSearchDTO.DateEnd);
            }

            int pageSize = orderSearchDTO.PageNumber ?? 5;
            var result = await PaginatedList<Order>.CreateAsync(accounts.AsQueryable().AsNoTracking(), orderSearchDTO.PageIndex ?? 1, pageSize);
            return result;
        }

    }
}
