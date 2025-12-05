using Microsoft.AspNetCore.Mvc;

namespace DmsScoring.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
