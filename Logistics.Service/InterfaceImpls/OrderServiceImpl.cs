using Logistics.Data.DTO.Order;
using Logistics.Data.Entities;
using Logistics.Service.Commons;
using Logistics.Service.Interfaces;
using Logistics.Service.Repositories;
using QuanLySinhVien.Service.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Service.InterfaceImpls
{
    public class OrderServiceImpl : IOrderService
    {
        IOrderRepository _orderRepository;
        IProductRepository _productRepository;
        IUnitOfWork _unitOfWork;

        public OrderServiceImpl(IOrderRepository orderRepository, IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this._orderRepository = orderRepository;
            this._productRepository= productRepository;
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

        public OrderDetailDTO GetOrderDTOById(string id)
        {
            var order = _orderRepository.GetOrderById(id);
            var products = _productRepository.GetAllProductsByOrderId(id);
            OrderDetailDTO orderDetail = new OrderDetailDTO()
            {
                Id = id,
                CustomerName = order.CustomerName,
                CustomerAddress = order.CustomerAddress,
                CustomerEmail = order.CustomerEmail,
                CustomerPhone = order.CustomerPhone,
                DeliveryAddress = order.DeliveryAddress,
                DeliveryDate = order.DeliveryDate,
                EstimateDeliveryDate= order.DeliveryDate,
                Status = order.Status
            };

            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (var item in products)
            {
                var isExist =  orderItems.Any(x=> x.ProductId == item.ProductId);
                if (isExist)
                {
                    var data = orderItems.FirstOrDefault(x => x.ProductId == item.ProductId);
                    data.Quantity = data.Quantity + item.Quantity;
                    data.TotalPrice = data.TotalPrice + item.TotalPrice;
                }
                else
                {
                    orderItems.Add(item);
                }
            }

            orderDetail.OrderItems = orderItems;
            return orderDetail;
        }

        public Task<PaginatedList<Order>> GetOrders(OrderSearchDTO orderSearchDTO)
        {
            var result = _orderRepository.GetOrders(orderSearchDTO);
            return result;
        }

        public bool UpdateOrder(Order order)
        {
            try
            {
                _orderRepository.Update(order);
                _unitOfWork.Commit();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateStatus(Order order)
        {
            try
            {
                _orderRepository.Update(order);
                _unitOfWork.Commit();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
