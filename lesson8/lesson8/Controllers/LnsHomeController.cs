using lesson8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lesson8.Controllers
{
    public class LnsHomeController : Controller
    {
        private readonly ILogger<LnsHomeController> _logger;

        public LnsHomeController(ILogger<LnsHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LnsInforStudents()
        {
            ViewBag.Infor = new
            {
                Hovaten="Lê Ng?c S?n",
                Lop="K23CNT1",
                SDT="0343288214"
            }    
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
