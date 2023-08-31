using Logistics.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System;
using Logistics.Data.Entities;
using Newtonsoft.Json;
using Logistics.Data.DTO.Order;
using QuanLySinhVien.WebApp.Commons;
using Logistics.Service.Commons;

namespace Logistics.WebAppAdmin.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IOrderService _orderService;

        public OrderController(ILogger<OrderController> logger, IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetOrders(string body)
        {
            OrderSearchDTO model = JsonConvert.DeserializeObject<OrderSearchDTO>(body);

            var results = await _orderService.GetOrders(model);

            if (results.Capacity > 0) {
                ApiResult<OrderGridPagingDTO<Order>> result = new ApiResult<OrderGridPagingDTO<Order>>();
                OrderGridPagingDTO<Order> resultPaging = new OrderGridPagingDTO<Order>()
                {
                    Items = results,
                    PageIndex = results.PageIndex,
                    PageSize = results.Capacity,
                    TotalPages = results.TotalPages
                };
                var a = results.PageIndex;
                result.Message = "";
                result.ResultObj = resultPaging;
                result.statusCode = 200;
                return Json(result);
            }
            else
            {
                ApiResult<string> result = new ApiResult<string>();
                result.Message = "No data.";
                result.ResultObj = "";
                result.statusCode = 200;
                return Json(result);
            }
        }

        public IActionResult Detail(string id)
        {
            var order = _orderService.GetOrderById(id);
            return View(order);
        }

        [HttpPost]
        public JsonResult UpdateOrder(string body)
        {
            OrderUpdateDTO model = JsonConvert.DeserializeObject<OrderUpdateDTO>(body);
            var order = _orderService.GetOrderById(model.Id);

            if (order != null)
            {
                //order.Id= model.Id;
                order.CustomerName = model.CustomerName;
                order.CustomerPhone = model.CustomerPhone;
                order.CustomerEmail = model.CustomerEmail;
                order.CustomerAddress = model.CustomerAddress;
                order.DeliveryAddress = model.DeliveryAddress;
                order.DeliveryDate = model.DeliveryDate;
                order.EstimateDeliveryDate = model.EstimateDeliveryDate;
                order.UpdatedDate = DateTime.Now;
                order.Status = order.Status;
                ApiResult<bool> result = new ApiResult<bool>();
                var isUpdated = _orderService.UpdateOrder(order);
                if (isUpdated)
                {
                    result.ResultObj = isUpdated;
                    result.Message = "Update successfully.";
                    result.statusCode = 200;
                }
                else
                {
                    result.ResultObj = isUpdated;
                    result.Message = "Update fail.";
                    result.statusCode = 200;
                }

                return Json(result);
            }
            else
            {
                ApiResult<string> result = new ApiResult<string>();
                result.Message = "No data.";
                result.ResultObj = "";
                result.statusCode = 200;
                return Json(result);
            }
        }

        [HttpPost]
        public  JsonResult UpdateStatus(string id)
        {
            var order =  _orderService.GetOrderById(id);

            if (order != null)
            {

                order.Status = !order.Status;
                ApiResult<bool> result = new ApiResult<bool>();
                var isUpdated = _orderService.UpdateStatus(order);
                if (isUpdated)
                {
                    result.ResultObj = isUpdated;
                    result.Message = "Update status to delivered.";
                    result.statusCode = 200;
                }
                else
                {
                    result.ResultObj = isUpdated;
                    result.Message = "Update status fail.";
                    result.statusCode = 200;
                }

                return Json(result);
            }
            else
            {
                ApiResult<string> result = new ApiResult<string>();
                result.Message = "No data.";
                result.ResultObj = "";
                result.statusCode = 200;
                return Json(result);
            }
        }
    }
}
