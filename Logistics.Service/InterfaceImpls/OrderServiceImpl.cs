using Logistics.Data.DTO.Order;
using Logistics.Data.Entities;
using Logistics.Service.Commons;
using Logistics.Service.Interfaces;
using Logistics.Service.Repositories;
using QuanLySinhVien.Service.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Service.InterfaceImpls
{
    public class OrderServiceImpl : IOrderService
    {
        IOrderRepository _orderRepository;
        IUnitOfWork _unitOfWork;

        public OrderServiceImpl(IOrderRepository orderRepository, IUnitOfWork unitOfWork)
        {
            this._orderRepository = orderRepository;
            this._unitOfWork = unitOfWork;
        }

        public bool CreateOrder(OrderCreateDTO order)
        {
            Order o = new Order()
            {
                Id = order.OrderId,
                CustomerName = order.CustomerName,
                CustomerAddress = order.CustomerAddress,
                CustomerEmail = order.CustomerEmail,
                CustomerPhone = order.CustomerPhone,
                DeliveryAddress = order.DeliveryAddress,
                DeliveryDate = DateTime.Now.AddDays(1),
                EstimateDeliveryDate = DateTime.Now.AddDays(2),
                Isdeleted = false,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Status = false
            };


            try
            {
                _orderRepository.Add(o);
                _unitOfWork.Commit();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Order GetOrderById(string id)
        {
            return _orderRepository.GetOrderById(id);
        }

        public Task<PaginatedList<Order>> GetOrders(OrderSearchDTO orderSearchDTO)
        {
            var result = _orderRepository.GetOrders(orderSearchDTO);
            return result;
        }

        public bool UpdateStatus()
        {
            throw new NotImplementedException();
        }
    }
}
