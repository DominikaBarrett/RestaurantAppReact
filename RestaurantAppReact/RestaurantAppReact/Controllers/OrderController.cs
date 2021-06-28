using Microsoft.AspNetCore.Mvc;

namespace RestaurantAppReact.Controllers
{
    public class OrderController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}