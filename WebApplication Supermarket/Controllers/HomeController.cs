using Microsoft.AspNetCore.Mvc;

namespace WebApplication_Supermarket.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
