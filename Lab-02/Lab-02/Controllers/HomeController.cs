using Microsoft.AspNetCore.Mvc;

namespace Lab_02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}