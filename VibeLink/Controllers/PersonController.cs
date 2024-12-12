using Microsoft.AspNetCore.Mvc;

namespace VibeLink.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Kindex()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }
    }
}
