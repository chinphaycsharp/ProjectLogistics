using Logistics.Data.DTO.Order;
using Logistics.Data.Entities;
using Logistics.Service.Interfaces;
using Logistics.WebAppAdmin.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using QuanLySinhVien.WebApp.Commons;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logistics.WebAppAdmin.Areas.ClientApp.Controllers
{
    [Area("ClientApp")]
    public class ProductClientController : Controller
    {
        private readonly IProductService _productService;

        public ProductClientController(ILogger<OrderController> logger, IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public  JsonResult GetProducts()
        {
            var results =  _productService.GetProducts();

            if (results.Capacity > 0)
            {
                ApiResult<List<Product>> result = new ApiResult<List<Product>>();
                result.Message = "";
                result.ResultObj = results;
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
        public JsonResult GetProductById(string id)
        {
            var product = _productService.GetProductById(id);

            if (product != null)
            {
                ApiResult<Product> result = new ApiResult<Product>();
                result.Message = "";
                result.ResultObj = product;
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
