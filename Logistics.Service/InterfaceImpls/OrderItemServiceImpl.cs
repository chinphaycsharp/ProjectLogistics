﻿using Logistics.Data.DTO.Order;
using Logistics.Data.Entities;
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
    public class OrderItemServiceImpl : IOrderDetailService
    {
        IOrderDetailRepository _orderDetailRepository;
        IUnitOfWork _unitOfWork;

        public OrderItemServiceImpl(IOrderDetailRepository orderDetailRepository, IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this._orderDetailRepository = orderDetailRepository;
            this._unitOfWork = unitOfWork;
        }


        public bool CreateOrderDetail(OrderItem order)
        {
            OrderDetail o = new OrderDetail()
            {
                OrderId = order.OrderId,
                ProductId = order.ProductId,
                Quantity = order.Quantity,
                TotalPrice = order.TotalPrice,
            };

            try
            {
                _orderDetailRepository.Add(o);
                _unitOfWork.Commit();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteOrderDetail(OrderDetail order)
        {
            try
            {
                _orderDetailRepository.Delete(order);
                _unitOfWork.Commit();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<OrderDetail> GetAllOrderDetailByOrderId(string orderId)
        {
            var orderdetails = _orderDetailRepository.GetAll().Where(x=>x.OrderId == orderId);
            return orderdetails.ToList();
        }
    }
}
