
using Logistics.Data.Entities;
using Logistics.Service.Interfaces;
using Logistics.WebAppAdmin.Commons;
using Logistics.WebAppAdmin.Models.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using QuanLySinhVien.WebApp.Commons;
using System;

namespace Logistics.WebAppAdmin.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IConfiguration _config;
        public AuthController(IAccountService acountService, IConfiguration config)
        {
            _accountService = acountService;
            _config = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Login(string body)
        {
            AccountLoginViewModel model = JsonConvert.DeserializeObject<AccountLoginViewModel>(body);
            if (model == null)
            {
                ApiResult<string> result = new ApiResult<string>();
                result.Message = "Please enter your password and password.";
                result.ResultObj = "";
                result.statusCode = 200;
                return Json(result);
            }

            try
            {
                var account = _accountService.GetAccountByUserNameAndPassword(model.UserName, EncryptionHelper.ToMD5(model.Password));
                ApiResult<Account> dto = new ApiResult<Account>();

                if (account != null)
                {
                    var userLogin = new UserStorage()
                    {
                        id = account.Id,
                        username = account.Username,
                        token = GenerateToken.Generate(account, _config),
                    };

                    string jsonSave = JsonConvert.SerializeObject(userLogin);
                    HttpContext.Session.SetString(CommonConst.user_session, jsonSave);
                    dto.statusCode = 200;
                    dto.ResultObj = account;
                    dto.Message = "";
                    return Json(dto);
                }
                else
                {
                    dto.statusCode = 200;
                    dto.ResultObj = null;
                    dto.Message = "You have entered the wrong account or password, please try again.";
                    return Json(dto);
                }
            }
            catch (Exception ex)
            {
                ApiResult<string> result = new ApiResult<string>();
                result.statusCode = 500;
                result.ResultObj = ex.Message;
                result.Message = "Something went wrong with the system, please try again.";
                return Json(result);
            }
        }
    }
}
