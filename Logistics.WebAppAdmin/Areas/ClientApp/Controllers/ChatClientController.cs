using Logistics.Data.DTO.Chat;
using Logistics.Data.Entities;
using Logistics.Service.Interfaces;
using Logistics.WebAppAdmin.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using QuanLySinhVien.WebApp.Commons;
using System.Collections.Generic;

namespace Logistics.WebAppAdmin.Areas.ClientApp.Controllers
{
    [Area("ClientApp")]
    public class ChatClientController : Controller
    {
        private readonly IChatService _IChatService;

        public ChatClientController(IChatService iChatService)
        {
            _IChatService = iChatService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetMessages()
        {
            var results = _IChatService.GetVMessages();

            if (results.Capacity > 0)
            {
                ApiResult<List<VMessage>> result = new ApiResult<List<VMessage>>();
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
    }
}
