using Microsoft.AspNetCore.Mvc;

namespace VibeLink.Controllers
{
    public class EventsController : Controller
    {
        public ActionResult UserIndex()
        {
            return View();
        }
        public ActionResult Events()
        {
            return View();
        }
    }
}
