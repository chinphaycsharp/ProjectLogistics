using Logistics.Data.DTO.Comment;
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
    public class CommentClientController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentClientController( ICommentService commentService)
        {
            _commentService = commentService;
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Add(string body)
        {
            CommentCreateDTO model = JsonConvert.DeserializeObject<CommentCreateDTO>(body);
            if (model != null)
            {
                ApiResult<bool> result = new ApiResult<bool>();

                var isSuccess = _commentService.AddComment(model);
                if (isSuccess)
                {
                    result.Message = "Create successfully.";
                    result.ResultObj = true;
                    result.statusCode = 200;
                    return Json(result);
                }
                else
                {
                    result.Message = "Create fail. Please try again.";
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
    }
}
