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

            //ViewData["CurrentFilter"] = searchString;
            if (results.Capacity > 0) {
                ApiResult<OrderGridPagingDTO<Order>> result = new ApiResult<OrderGridPagingDTO<Order>>();
                OrderGridPagingDTO<Order> resultPaging = new OrderGridPagingDTO<Order>()
                {
                    Items = results,
                    PageIndex = results.PageIndex,
                    PageSize = results.TotalPages
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
    }
}
