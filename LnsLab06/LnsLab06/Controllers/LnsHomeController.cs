using LnsLab06.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LnsLab06.Controllers
{
    public class LnsHomeController : Controller
    {
        private readonly ILogger<LnsHomeController> _logger;

        public LnsHomeController(ILogger<LnsHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult LnsIndex()
        {
            return View();
        }

        public IActionResult LnsInfoStudent()
        {
            ViewBag.Info = new
            {
                HoVaTen = "Lê Ngọc Sơn",
                Lop = "K23CNT1",
                SDT = "0343288214",
            };
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
