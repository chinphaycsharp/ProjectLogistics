using Logistics.Data.DTO.Order;
using Logistics.Data.Entities;
using Logistics.Service.Interfaces;
using Logistics.WebAppAdmin.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using QuanLySinhVien.WebApp.Commons;
using System;
using System.Threading.Tasks;

namespace Logistics.WebAppAdmin.Areas.ClientApp.Controllers
{
    [Area("ClientApp")]
    public class OrderClientController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;

        public OrderClientController(ILogger<OrderController> logger, IOrderService orderService, IOrderDetailService orderDetailService)
        {
            _orderService = orderService;
            _orderDetailService = orderDetailService;
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

            if (results.Capacity > 0)
            {
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

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Add(string body)
        {
            OrderCreateDTO model = JsonConvert.DeserializeObject<OrderCreateDTO>(body);
            if (model != null)
            {
                ApiResult<bool> result = new ApiResult<bool>();
                OrderCreateDTO order = new OrderCreateDTO()
                {
                    OrderId = model.OrderId,
                    Status = model.Status,
                    CustomerAddress = model.CustomerAddress,
                    CustomerEmail = model.CustomerEmail,
                    CustomerName = model.CustomerName,
                    CustomerPhone = model.CustomerPhone,
                    DeliveryAddress = model.DeliveryAddress,
                    DeliveryDate = model.DeliveryDate,
                    EstimateDeliveryDate = DateTime.Now.AddDays(3),
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                };

                var isSuccess = _orderService.CreateOrder(order);
                if(isSuccess)
                {
                    foreach (var item in model.OrderItems)
                    {
                        isSuccess = _orderDetailService.CreateOrderDetail(item);
                    }
                }
                if (isSuccess)
                {
                    result.Message = "Create successfully.";
                    result.ResultObj = true;
                    result.statusCode = 200;
                    return Json(result);
                }
                else
                {
                    result.Message = "Create order fail. Please try again.";
                    result.ResultObj = false;
                    result.statusCode = 200;
                    return Json(result);
                }
            }
            else
            {
                ApiResult<bool> result = new ApiResult<bool>();
                result.Message = "Some error. Please try again serviral minutes.";
                result.ResultObj = false;
                result.statusCode = 200;
                return Json(result);
            }
        }

        public IActionResult Detail(string id)
        {
            var order = _orderService.GetOrderDTOById(id);
            return View(order);
        }
    }
}
