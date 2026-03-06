using Microsoft.AspNetCore.Mvc;

namespace test.Controllers
{
    public class Home1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
