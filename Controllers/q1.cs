using Microsoft.AspNetCore.Mvc;

namespace startup1.Controllers
{
    public class q1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult profile()
        {
            return View();
        }

        public IActionResult company()
        {
            return View();
        }

        public IActionResult product()
        {
            return View();
        }

        public IActionResult collab()
        {
            return View();
        }
    }
}
