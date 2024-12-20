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
        public ActionResult BrowseEvents()
        {
            return View();
        }
        public ActionResult CreateEvent()
        {
            return View();
        }
        public ActionResult MyEventHistory()
        {
            return View();
        }
    }
}
