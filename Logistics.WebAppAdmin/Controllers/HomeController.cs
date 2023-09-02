using Logistics.Data.DTO.Chat;
using Logistics.Data.Entities;
using Logistics.Service.Interfaces;
using Logistics.WebAppAdmin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using QuanLySinhVien.WebApp.Commons;
using System.Collections.Generic;
using System.Diagnostics;

namespace Logistics.WebAppAdmin.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVTopOrderMaxPriceService _vTopOrderMaxPrice;

        public HomeController(ILogger<HomeController> logger, IVTopOrderMaxPriceService vTopOrderMaxPriceService)
        {
            _logger = logger;
            _vTopOrderMaxPrice = vTopOrderMaxPriceService;
        }

        public IActionResult Index()
        {
            List<VTopOrderMaxPrice> results = _vTopOrderMaxPrice.GetVTopOrderMaxPrices();
            return View(results);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       
    }
}
