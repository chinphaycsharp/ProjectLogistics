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
using Logistics.Data.DTO.Comment;

namespace Logistics.WebAppAdmin.Controllers
{
    public class CommentController : BaseController
    {
        private readonly ICommentService _commentService;

        public CommentController(ILogger<OrderController> logger, ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetComments(string body)
        {
            CommentSearchDTO model = JsonConvert.DeserializeObject<CommentSearchDTO>(body);

            var results = await _commentService.GetComments(model);

            if (results.Capacity > 0) {
                ApiResult<OrderGridPagingDTO<Comment>> result = new ApiResult<OrderGridPagingDTO<Comment>>();
                OrderGridPagingDTO<Comment> resultPaging = new OrderGridPagingDTO<Comment>()
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

        public IActionResult Detail(int id)
        {
            var order = _commentService.GetCommentById(id);
            return View(order);
        }

        [HttpPost]
        public JsonResult UpdateComment(string body)
        {
            CommetUpdateDTO model = JsonConvert.DeserializeObject<CommetUpdateDTO>(body);
            var order = _commentService.GetCommentById(model.Id);

            if (order != null)
            {
                order.CountStars = model.CountStars;
                order.Content = model.Content;
                order.UpdatedDate = DateTime.Now;
                order.CreatedDate = DateTime.Now;
                order.ClientName = model.ClientName;
                order.Isdeleted = false;
                ApiResult<bool> result = new ApiResult<bool>();
                var isUpdated = _commentService.UpdateComment(order);
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
        public JsonResult DeleteComment(int id)
        {
            var order = _commentService.GetCommentById(id);

            if (order != null)
            {
                ApiResult<bool> result = new ApiResult<bool>();
                var isUpdated = _commentService.DeleteComment(order);
                if (isUpdated)
                {
                    result.ResultObj = isUpdated;
                    result.Message = "Comment has been deleted.";
                    result.statusCode = 200;
                }
                else
                {
                    result.ResultObj = isUpdated;
                    result.Message = "Comment order fail.";
                    result.statusCode = 200;
                }

                return Json(result);
            }
            else
            {
                ApiResult<string> result = new ApiResult<string>();
                result.Message = "Error system.";
                result.ResultObj = "";
                result.statusCode = 200;
                return Json(result);
            }
        }
    }
}
