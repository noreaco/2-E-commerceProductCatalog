using _2_E_commerceProductCatalog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _2_E_commerceProductCatalog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult shop()
        {
            ViewBag.tit = "التسوق";
            return View();
        }
         public IActionResult cart()
        {
            ViewBag.tit = "عربة التسوق";
            return View();
        }
        public IActionResult login()
        {
            ViewBag.tit = "تسجيل الدخول";
            return View();
        }
         public IActionResult wishlist()
        {
            ViewBag.tit = "قائمة الرغبات";
            return View();
        }
         public IActionResult gallery()
        {
            ViewBag.tit = "المعرض";
            return View();
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