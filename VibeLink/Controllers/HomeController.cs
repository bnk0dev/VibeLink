using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VibeLink.Models;

namespace VibeLink.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public ActionResult About()
        {
            return View();
        }

        
        public ActionResult Activ()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult sss()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return RedirectToAction("Kindex");
            }
            else
            {
                ViewBag.ErrorMessage = "Geçersiz kullanýcý adý veya þifre !";
                return View();
            }
        }

        public ActionResult Kindex()
        {
            return View();
        }
        public IActionResult Index()
        {
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
