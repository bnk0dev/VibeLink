using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VibeLink.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult UserIndex()
        {
            return View();
        }
        public ActionResult Settings()
        {
            return View();
        }


    }
}
